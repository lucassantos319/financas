using FinancasAPI.Applications.Services.Tokens;
using FinancasAPI.Domain.Entities;
using FinancasAPI.Domain.Entities.Factory;
using FinancasAPI.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancasAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly UserFactory _userFactory;

        public UserController(IUserService userService)
        {
            _userService = userService;
            _userFactory = new UserFactory();
        }

        [HttpGet]
        [Authorize]
        [Route("all")]
        public IActionResult GetAllUsers()
        {
            try
            {
                return Ok(_userService.GetAllUsers());
            }
            catch(Exception ex)
            {
                return Problem($"Message: {ex.Message}\nInnerException: {ex.InnerException}\nStack: {ex.StackTrace}");
            }
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginRequestModel loginRequester)
        {
            var userInfos = _userService.Login(loginRequester.email,loginRequester.password);
            if (userInfos == null)
                return Problem($"Usuario {loginRequester.email} não existente");

            return Ok(userInfos); 
        }

        
        [HttpGet]
        [Authorize]
        public IActionResult GetUserByEmail(string email)
        {
            try
            {
                var user = _userService.GetUserByEmail(email);
                var token = GenerateTokenService.GenerateToken(user);
                return Ok ();
            }
            catch(Exception ex)
            {
                return Problem($"Message: {ex.Message}\nInnerException: {ex.InnerException}\nStack: {ex.StackTrace}");
            }
        }


        [HttpPost]
        public IActionResult CreateUser(object user)
        {
            try
            {
                var newUser = _userFactory.NewUser(user);
                _userService.CreateUser(newUser);

                return Ok("Usuário criado com sucesso");
            }
            catch(Exception ex)
            {
                return Problem($"Message: {ex.Message}\nInnerException: {ex.InnerException}\nStack: {ex.StackTrace}");
            }
        }

        

    }
}
