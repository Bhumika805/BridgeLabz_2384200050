using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{

    //Model layer ka use data ko structure provide krne k liye use hota h
    //Business Layer aur Repository Layer ke beech bridge ka kaam  krti h 
    // Repository Layer database se data fetch karke Model Layer ko return karti hai
    //Business Layer Model Layer ka use karke logic apply karti hai.

    //DTO = data transfer objects

    public class LoginDTO
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }


        //convert the object to its string representation so that it is suitable for display 
        public override string ToString()
        {
            try
            {
                return "Firstname " + firstname +
                    " Lastname " + lastname +
                    " Email " + email +
                    " Password " + password;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in ToString: " + ex.Message);
                return "Error converting LoginDTO to string.";
            }
        }
    }
}

