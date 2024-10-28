using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Header;
using MyAPI.Model;
using MyAPI.Repository;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository accountRepository;

        public AccountController(IAccountRepository _repo)
        {
            accountRepository = _repo;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            var result = await accountRepository.SignUpAsync(model);

            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            else
            {
                // Lấy chi tiết lỗi từ IdentityResult
                var errors = result.Errors.Select(e => e.Description);
                return BadRequest(new { Errors = errors });
            }
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignInModel model)
        {

            var result = await accountRepository.SignInAsync(model);

            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);

        }

        [HttpPut("Updaterole")]
        [Authorize(Roles = ApplicationRole.Admin)]
        public async Task<IActionResult> UpdateUserRole(string email, string newRole)
        {
            var model = new UpdateUserModel
            {
                Email = email,
                NewRole = newRole
            };

            var result = await accountRepository.UpdateUserAsync(model);
            if (result.Succeeded)
            {
                return Ok("User role updated successfully.");
            }
            return BadRequest("Failed to update user role.");
        }

    }
}
