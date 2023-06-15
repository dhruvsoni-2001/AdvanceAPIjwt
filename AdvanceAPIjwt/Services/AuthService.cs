﻿using AdvanceAPIjwt.Models;
using Microsoft.AspNetCore.Identity;

namespace AdvanceAPIjwt.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> Register(RegisterUser user)
        {
            var applicationUser = new ApplicationUser
            {
                UserName = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                
            };

            var result = await _userManager.CreateAsync(applicationUser, user.Password);
            return result.Succeeded;
        }

        public async Task<bool> Login(LoginUser user)
        {
            var applicationUser = await _userManager.FindByEmailAsync(user.Email);
            if (applicationUser is null)
            {
                return false;
            }

            return await _userManager.CheckPasswordAsync(applicationUser, user.Password);
        }
    }
}