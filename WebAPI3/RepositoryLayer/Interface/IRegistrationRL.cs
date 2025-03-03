using ModelLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Interface
{
    public interface IRegistrationRL
    {
        public string GetHello(string name);

        public LoginDTO GetUsernamePassword(LoginDTO loginDTO);

        public UserEntity Registration(RegistrationDTO registrationDTO);
    }

}
