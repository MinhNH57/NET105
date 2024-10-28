using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MyAPI.Data;
using MyAPI.Header;
using MyAPI.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MyAPI.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> userManage;

        public SignInManager<ApplicationUser> SignInManage;

        private readonly IConfiguration config;
        private readonly RoleManager<IdentityRole> roleManage;

        public AccountRepository(UserManager<ApplicationUser> userManage , SignInManager<ApplicationUser> SignInManage , IConfiguration config , RoleManager<IdentityRole> roleManage)
        {
            this.userManage = userManage;
            this.SignInManage = SignInManage;
            this.config = config;
            this.roleManage = roleManage;
        }
        public async Task<string> SignInAsync(SignInModel model)
        {
            var user = await userManage.FindByEmailAsync(model.Email);
            var passCheck = await userManage.CheckPasswordAsync(user, model.Password);
            if (user == null || !passCheck)
            {
                return string.Empty;
            }
            var result = await SignInManage.PasswordSignInAsync(model.Email, model.Password, false, false);
            if (!result.Succeeded)
            {
                return string.Empty;
            }

            var authclaims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, model.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var userRole = await userManage.GetRolesAsync(user);

            foreach (var role in userRole)
            {
                authclaims.Add(new Claim(ClaimTypes.Role, role.ToString()));
            }

            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: config["JWT:ValidIssuer"],
                audience: config["JWT:ValidAudience"],
                expires: DateTime.Now.AddMinutes(20),
                claims: authclaims,
                signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
             );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            var user = new ApplicationUser()
            {
                FullName = model.FullName,
                Email = model.Email,
                UserName = model.Email,
            };

            var result =  await userManage.CreateAsync(user , model.Password);
            if(result.Succeeded)
            {
                if(!await roleManage.RoleExistsAsync(ApplicationRole.Custom))
                {
                    await roleManage.CreateAsync(new IdentityRole(ApplicationRole.Custom));
                }

                await userManage.AddToRoleAsync(user, ApplicationRole.Custom);
            }
            return result;
        }

        public async Task<IdentityResult> UpdateUserAsync(UpdateUserModel model)
        {
            var user = await userManage.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });
            }

            // Xóa tất cả các vai trò hiện tại của người dùng
            var currentRoles = await userManage.GetRolesAsync(user);
            if (currentRoles.Count > 0)
            {
                await userManage.RemoveFromRolesAsync(user, currentRoles);
            }

            // Thêm vai trò mới
            if (!await roleManage.RoleExistsAsync(model.NewRole))
            {
                // Tạo vai trò mới nếu chưa tồn tại
                await roleManage.CreateAsync(new IdentityRole(model.NewRole));
            }

            var result = await userManage.AddToRoleAsync(user, model.NewRole);
            return result;
        }
    }
}
