using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Hack : EmployeeInfo
    {
        public string StoreUserID { get; set; }
        public string StorePassword { get; set; }
        public void GetUserInfo()
        {
            StoreUserID = UserID;
            StorePassword = Password;
        }
        
        public void ShowKeyInfo()
        {
            Console.WriteLine($"Key Info {KeyInfo}");
        }
        public void ShowUserInfo()
        {
            Console.WriteLine("your used ID "+UserID);
            Console.WriteLine("Your password "+Password);
            Console.WriteLine("Your KeyInfo "+KeyInfo);
        }
    }
}