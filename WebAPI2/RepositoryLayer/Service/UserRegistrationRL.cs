using ModelLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL
    {


        //Get k liye h yh 
        public (string, string) RegistrationRL(string username, string password)
        {
            return ("root", "root");
        }


        //Post k liye h 
        private string databasefirstname = "Bhumika";
        private string databaselastname = "Sharma";
        private string databaseEmail = "bhumikasharma@gmail.com";
        public LoginDTO GetFirstnameLastname(LoginDTO loginDTO)
        {
            try
            {
                loginDTO.firstname = databasefirstname;
                loginDTO.lastname = databaselastname;
                return loginDTO;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetFirstnameLastname: " + ex.Message);
                return null;
            }
        }

        public LoginDTO GetEmail(LoginDTO loginDTO)
        {
            try
            {
                loginDTO.email = databaseEmail;
                return loginDTO;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in GetEmail: " + ex.Message);
                return null;
            }
        }

    }


}
