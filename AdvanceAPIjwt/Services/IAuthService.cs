using AdvanceAPIjwt.Models;


namespace AdvanceAPIjwt.Services
{
    public interface IAuthService
    {
        string GenerateTokenString(LoginUser user);
        Task<bool> Login(LoginUser user);
        Task<bool> RegisterUser(RegisterUser user);
    }
}
