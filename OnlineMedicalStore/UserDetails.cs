using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// UserDetails Class  used to create instance for user details  <see cref="UserDetails"/>
    /// </summary> 
    public class UserDetails : PersonalDetails,IWallet
    {
        /// <summary>
        /// Balance private field used to store balance value of the user <see cref="UserDetails"/>
        /// </summary>
        private int Balance;
        /// <summary>
        /// s_uNumber is a private static method used for auto inncrement <see cref="UserDetails"/>
        /// </summary> 
        private static int s_uNumber = 1001;
        /// <summary>
        /// UserID property is used to store users ID<see cref="UserDetails"/>
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// WalletBalance property is used to show users WalletBalance<see cref="UserDetails"/>
        /// </summary>
        public int WalletBalance { get{return Balance;} }
        /// <summary>
        /// this constructor is used to asigne value to property<see cref="UserDetails"/>
        /// </summary>
        /// <param name="name">name gives the user name</param>
        /// <param name="age">age gives the user age</param>
        /// <param name="city">city gives the user city</param>
        /// <param name="phonenumber">phonenumber gives the user phonenumber</param>
        /// <param name="balance">balance gives the user balance</param> 
        public UserDetails(string name ,int age,string city,string phonenumber,int balance):base(name,age,city,phonenumber)
        {
            UserID = "UID"+s_uNumber;
            s_uNumber++;
            Balance =balance;
        }
        /// <summary>
        /// this constructor is used for reading data from csv file<see cref="UserDetails"/>
        /// </summary>
        /// <param name="userID">userID gives the user userID</param>
        /// <param name="name">name gives the user name</param>
        /// <param name="age">age gives the user age</param>
        /// <param name="city">city gives the user city</param>
        /// <param name="phonenumber">phonenumber gives the user phonenumber</param>
        /// <param name="balance">balance gives the user balance</param> <summary>
        public UserDetails(string userID, string name ,int age,string city,string phonenumber,int balance):base(name,age,city,phonenumber)
        {
            UserID = userID;
            s_uNumber= int.Parse(userID.Remove(0,3));
            Balance = balance;
        }
        /// <summary>
        /// WalletRecharge method is used to add amount to balance<see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount">amount gives value need to be added</param>
        public void WalletRecharge(int amount)
        {
            Balance = Balance+amount;
        }
        /// <summary>
        /// DeductBalance method is used to Deduct amount from balance<see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount">amount gives value need to be Deduct</param>
        public void DeductBalance(int amount)
        {
            Balance = Balance+amount;
        }

    }
}