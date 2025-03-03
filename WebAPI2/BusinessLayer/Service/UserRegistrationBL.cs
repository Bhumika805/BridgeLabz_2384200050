using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _obj;
        public UserRegistrationBL(UserRegistrationRL obj)
        {
            _obj = obj;
        }

        // yh get wale k liye kaam krra h 
        public string RegistrationBL(string username, string password)
        {
            var (user, pass) = _obj.RegistrationRL(username, password);
            if (username == user && password == pass)
            {
                return "Login Sucessfuylly";
            }
            else
            {
                return "Invalid";
            }

        }


        //yh post wale k liye kaam krra h 
        public bool loginuser(LoginDTO loginDTO)
        {
            try
            {
                string frontendfirstname = loginDTO.firstname;
                string frontendlastname = loginDTO.lastname;
                string frontendemail = loginDTO.email;
                string frontendpassword = loginDTO.password;

                LoginDTO resultFirstLast = _obj.GetFirstnameLastname(loginDTO);
                LoginDTO resultEmail = _obj.GetEmail(loginDTO);

                bool res = checkFirstnameLastname(frontendfirstname, frontendlastname, resultFirstLast);

                return res;

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in loginuser: " + ex.Message);
                return false; // Agar koi error aaye toh false return kare
            }
        }



        public bool checkFirstnameLastname(string frontendfirstname, string frontendlastname, LoginDTO resultFirstLast)
        {
            try
            {


                if (resultFirstLast == null) return false;
                if (frontendfirstname.Equals(resultFirstLast.firstname) && frontendlastname.Equals(resultFirstLast.lastname))
                {
                    return true;
                }
                return false;

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in checkFirstnameLastname: " + ex.Message);
                return false; // Error aaye toh false return kare
            }
        }

        public bool checkEmail(string frontendemail, LoginDTO resultEmail)
        {
            try
            {
                if (resultEmail == null) return false;
                if (frontendemail.Equals(resultEmail.email))
                {
                    return true;
                }
                return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in checkEmail: " + ex.Message);
                return false; // Error aaye toh false return kare
            }
        }
    }

}
