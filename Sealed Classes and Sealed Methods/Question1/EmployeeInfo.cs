using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public sealed class EmployeeInfo : PersonalInfo
    {
        //UserID, Password, KeyInfo = 100
        public string UserID { get; set; }
        public string Password { get; set; }
        public int KeyInfo { get; set; }
        public void UpdateInfo(string userID,string password,int keyInfo)
        {
            UserID = userID;
            Password = password;
            KeyInfo = 100;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("your used ID "+UserID);
            Console.WriteLine("Your password "+Password);
            Console.WriteLine("Your KeyInfo "+KeyInfo);
        }
        
    }
}