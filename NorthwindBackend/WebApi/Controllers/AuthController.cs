using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
              _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLoginResult = _authService.Login(userForLoginDto);

            if(!userToLoginResult.Success) {
                return BadRequest(userToLoginResult.Message);
            }

            var tokenResult = _authService.CreateAccessToken(userToLoginResult.Data);

            if(tokenResult.Success) {
                return Ok(tokenResult.Data);
            }

            return BadRequest(tokenResult.Message);
        }

        [HttpPost("register")]
        public IActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            //var userToLoginResult = _authService.Login(userForLoginDto);

            var userExists = _authService.UserExists(userForRegisterDto.Email);

            if (!userExists.Success)//kullanıcı varsa success false dönecek ve onu almak için trueya çevirmek lazım
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto,userForRegisterDto.Password);

            if (!registerResult.Success)
            {
                return BadRequest(registerResult.Message);
            }

            var tokenResult = _authService.CreateAccessToken(registerResult.Data);

            if (tokenResult.Success)
            {
                return Ok(tokenResult.Data);
            }

            return BadRequest(tokenResult.Message);
        }
    }
}
