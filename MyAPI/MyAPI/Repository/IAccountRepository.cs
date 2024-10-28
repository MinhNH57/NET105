using Microsoft.AspNetCore.Identity;
using MyAPI.Model;

namespace MyAPI.Repository
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SignInModel model);
        Task<IdentityResult> UpdateUserAsync(UpdateUserModel model);
    }
}
