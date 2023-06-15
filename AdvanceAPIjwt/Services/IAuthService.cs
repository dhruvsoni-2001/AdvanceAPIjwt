using AdvanceAPIjwt.Models;

namespace AdvanceAPIjwt.Services
{
    public interface IAuthService
    {
        Task<bool> Register(RegisterUser user);
    }
}
