using System;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using RepositoryLayer.Entity;
using BusinessLayer.Interface;
using NLog;

namespace BusinessLayer.Service
{
    public class RegistrationAPIBL : IRegistrationBL
    {
        private readonly IRegistrationRL _obj;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public RegistrationAPIBL(IRegistrationRL obj)
        {
            _obj = obj;
        }

        public string Registration(string name)
        {
            try
            {
                string response = "This is a Business Layer " + _obj.GetHello(name);
                logger.Info("User registered: " + name);
                return response;
            }
            catch (Exception ex)
            {
                logger.Error("Error in Registration: " + ex.Message);
                throw;
            }
        }

        public bool loginuser(LoginDTO loginDTO)
        {
            try
            {
                string frontendusername = loginDTO.username;
                string frontendpassword = loginDTO.password;
                LoginDTO result = _obj.GetUsernamePassword(loginDTO);
                bool res = checkUserNamePassword(frontendusername, frontendpassword, result);

                logger.Info("Login attempted for user: " + frontendusername);
                return res;
            }
            catch (Exception ex)
            {
                logger.Error("Error in loginuser: " + ex.Message);
                throw;
            }
        }

        public bool checkUserNamePassword(string frontendusername, string frontendpassword, LoginDTO result)
        {
            if (result == null)
            {
                logger.Warn("Login failed: User not found.");
                return false;
            }

            if (frontendusername.Equals(result.username) && frontendpassword.Equals(result.password))
            {
                logger.Info("User logged in successfully: " + frontendusername);
                return true;
            }

            logger.Warn("Login failed: Incorrect password for user " + frontendusername);
            return false;
        }

        public UserEntity registerBL(RegistrationDTO registrationDTO)
        {
            try
            {
                var result = _obj.Registration(registrationDTO);
                logger.Info("User registered successfully: " + registrationDTO.Email);
                return result;
            }
            catch (Exception ex)
            {
                logger.Error("Error in registerBL: " + ex.Message);
                throw;
            }
        }
    }
}
