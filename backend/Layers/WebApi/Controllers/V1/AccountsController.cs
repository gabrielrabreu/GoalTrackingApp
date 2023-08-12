using Infra.DbEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Security.Application.Interfaces;
using Security.Contracts;

namespace WebApi.Controllers.V1
{
    [AllowAnonymous]
    public class AccountsController : BaseController
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITokenService _tokenService;

        public AccountsController(SignInManager<ApplicationUser> signInManager,
                                  UserManager<ApplicationUser> userManager,
                                  ITokenService tokenService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _tokenService = tokenService;
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp(SignUpDto signUpDto)
        {
            var user = new ApplicationUser { UserName = signUpDto.Username, Email = signUpDto.Email };
            
            var result = await _userManager.CreateAsync(user, signUpDto.Password);
            
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return await TokenResult(user);
            }

            return BadRequest(result);
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn(SignInDto signInDto)
        {
            var result = await _signInManager.PasswordSignInAsync(signInDto.Username, signInDto.Password, false, false);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(signInDto.Username);

                if (user == null) 
                    return BadRequest();

                return await TokenResult(user);
            }

            return BadRequest(result);
        }

        private async Task<IActionResult> TokenResult(ApplicationUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);
            var token = _tokenService.GenerateToken(user, roles);
            return Ok(new { token });
        }
    }
}
