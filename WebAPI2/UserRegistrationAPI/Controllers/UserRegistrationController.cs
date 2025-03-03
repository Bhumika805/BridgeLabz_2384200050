using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelLayer.DTO;
using NLog;
namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {

        //log implementation
        private Logger logger = LogManager.GetCurrentClassLogger();
        UserRegistrationBL _obj;

        public UserRegistrationController(UserRegistrationBL obj)
        {
            _obj = obj;
        }

        [HttpGet]
        // yh data user(client) se ayega abhi hum hardcoded de rhe h kyuki data base nhi h or
        // yh business Layer ko bhej rhe h kyuki wha sirf login check hoga use mtlb nhi h
        // pta data kha se aa rha h 
        public string Registration()
        {
            string username = "root";
            string password = "root";
            string msg = _obj.RegistrationBL(username, password);
            return msg;
        }

        [HttpPost]

        //return string which is visible in the url directly (Not safe)
        //we can give value using Key-Value(params) 
        // iska model layer se koi mtlb nhi h 
        /*public string Login(string username, string password)
        {
            return username + ":" + password;
        }*/


        //Hiding string from URL Using JSON
        /* public string Login(LoginDTO logindto)
         {
             return logindto.ToString();
         }*/


        //Creating Response in a Standardized  manner using json
        /*public ResponseDTO<string> Login(LoginDTO logindto)
        {

            bool res = _obj.loginuser(logindto);
            var response = new ResponseDTO<string>();
            if (res)
            {
                response.success = true;
                response.message = "Login SuccessFully";
                response.data = logindto.ToString();
                //response.data = logindto.username;
                //response.data = logindto.password;
                
                return response;
            } 
            else
            {
                response.success = true;
                response.message = "Login UnsuccessFully";
                response.data = logindto.ToString();
                // response.data = logindto.username;
                //response.data = logindto.password;
                return response;
            }
            
        }*/


        // yh IAction result ko implement krna h 
        public IActionResult Login(LoginDTO logindto)
        {

            var response = new ResponseDTO<string>();
            bool res = _obj.loginuser(logindto);
            try
            {
                if (res)
                {
                    response.success = true;
                    response.message = "Login Sucessfull";
                    response.data = logindto.ToString();
                    logger.Info("User logged in successfully.");
                    return Ok(response);
                }
                response.success = false;
                response.message = "Login failed";
                response.data = "";
                logger.Warn("Login failed for email");
                return NotFound();
            }
            catch (Exception ex)
            {
                response.success = false;
                response.message = "Login failed";
                response.data = ex.Message;
                logger.Error("Exception occurred in login process for email");
                return BadRequest();
            }


        }
    }
}
