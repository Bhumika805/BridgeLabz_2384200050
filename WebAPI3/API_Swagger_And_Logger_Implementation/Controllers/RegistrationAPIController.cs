using Microsoft.EntityFrameworkCore;
using ModelLayer.DTO;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using NLog;

namespace API_Swagger_And_Logger_Implementation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationAPIController : ControllerBase
    {
        private readonly IRegistrationBL _obj;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public RegistrationAPIController(IRegistrationBL obj) => _obj = obj;

        [HttpGet]
        public string Get()
        {
            logger.Info("Get method called");
            return _obj.Registration("value from controller");
        }

        [HttpPost]
        public ResponseModelDTO<string> Postdata(LoginDTO loginDTO)
        {
            logger.Info($"Login attempt for user: {loginDTO.username}");
            bool result = _obj.loginuser(loginDTO);
            var response = new ResponseModelDTO<string>
            {
                success = result ? "true" : "false",
                message = result ? "Login Successful" : "Login Unsuccessful",
                data = result ? loginDTO.username : ""
            };
            return response;
        }

        [HttpPost("Register")]
        public IActionResult RegistrationUser(RegistrationDTO registrationDTO)
        {
            logger.Info($"Registration attempt for email: {registrationDTO.Email}");
            var result = _obj.registerBL(registrationDTO);
            return Created("User Created", result);
        }
    }
}