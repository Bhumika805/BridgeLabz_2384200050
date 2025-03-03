using Microsoft.EntityFrameworkCore;
using ModelLayer.DTO;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using NLog;

namespace RepositoryLayer.Service
{
    public class RegistrationAPIRL : IRegistrationRL
    {
        private readonly RegistrationContext _dbContext;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private const string databaseusername = "root";
        private const string databasepassword = "root";

        public RegistrationAPIRL(RegistrationContext dbContext) => _dbContext = dbContext;

        public string GetHello(string name)
        {
            logger.Info($"GetHello method called with name: {name}");
            return $"{name} Hello from Repository layer";
        }

        public LoginDTO GetUsernamePassword(LoginDTO loginDTO)
        {
            loginDTO.username = databaseusername;
            loginDTO.password = databasepassword;
            logger.Info("GetUsernamePassword method executed successfully.");
            return loginDTO;
        }

        public UserEntity Registration(RegistrationDTO registrationDTO)
        {
            var existingUser = _dbContext.Users.FirstOrDefault(e => e.Email == registrationDTO.Email);
            if (existingUser != null)
            {
                logger.Warn($"User already exists with email: {registrationDTO.Email}");
                return existingUser;
            }

            var newUser = new UserEntity
            {
                FirstName = registrationDTO.FirstName,
                LastName = registrationDTO.LastName,
                Email = registrationDTO.Email,
                Password = registrationDTO.Password,
            };
            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();
            logger.Info($"User registered successfully: {registrationDTO.Email}");
            return newUser;
        }
    }
}
