using AdvanceAPIjwt.Models;
using AdvanceAPIjwt.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceAPIjwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<bool> Register(RegisterUser user)
        {
            return await _authService.Register(user);
        }


        //[HttpPost]
        //public async Task<bool> Login(LoginUser user)
        //{
        //    return await _authService.Login(user);
        //}
    }
}
