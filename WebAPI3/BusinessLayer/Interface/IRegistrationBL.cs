using ModelLayer.DTO;
using RepositoryLayer.Entity;
using RepositoryLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IRegistrationBL
    {

        public string Registration(string name);


        public bool loginuser(LoginDTO loginDTO);

        public bool checkUserNamePassword(string frontendusername, string frontendpassword, LoginDTO result);

        public UserEntity registerBL(RegistrationDTO registrationDTO);

    }
}
