using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount.DisplayBankName();

            Account obj = new Account();

            obj.SwitchCases1();





        }
            
    }
}
