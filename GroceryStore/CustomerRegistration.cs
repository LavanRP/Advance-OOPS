using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    /// <summary>
    /// CustomerRegistration is holds information about the Customer <see cref="CustomerRegistration"/>
    /// </summary> 
    public class CustomerRegistration : PersonalDetails,IBalance
    {
        /// <summary>
        /// s_cNumber is private field used for auto increament in Customer ID<see cref="CustomerRegistration"/>
        /// </summary>
        private static int s_cNumber = 1000;
        /// <summary>
        /// CustomerID is used to store and give Customer's ID<see cref="CustomerRegistration"/>
        /// </summary>
        public string CustomerID  { get; set; }
        /// <summary>
        /// WalletBalance is used to store and give Customer's Wallet Balance<see cref="CustomerRegistration"/>
        /// </summary>
        public int WalletBalance { get; set; }
        /// <summary>
        /// this constructor is used to assigne values to property <see cref="CustomerRegistration"/>
        /// </summary>
        /// <param name="walletBalance">walletBalance gives customers walletBalance</param>
        /// <param name="name">name gives customers name</param>
        /// <param name="fathersName">fathersName gives customers fathersName</param>
        /// <param name="gender">gender gives customers gender</param>
        /// <param name="mobile">mobile gives customers mobile number</param>
        /// <param name="dob">dob gives customers dob</param>
        /// <param name="mailID">mailID gives customers mailID</param> 
        public CustomerRegistration(int walletBalance,string name,string fathersName,Gender gender,string mobile,DateTime dob,string mailID):base(name,fathersName,gender,mobile,dob,mailID)
        {
            s_cNumber++;
            CustomerID = "CID"+s_cNumber;
            
            WalletBalance = walletBalance;
        }
        /// <summary>
        /// this cunstroucter is used to read information from csv files<see cref="CustomerRegistration"/>
        /// </summary>
        /// <param name="customerID">walletBalance gives customers ID</param>
        /// <param name="walletBalance">walletBalance gives customers walletBalance</param>
        /// <param name="name">name gives customers name</param>
        /// <param name="fathersName">fathersName gives customers fathersName</param>
        /// <param name="gender">gender gives customers gender</param>
        /// <param name="mobile">walletBalance gives customers walletBalance</param>
        /// <param name="dob">dob gives customers dob</param>
        /// <param name="mailID">mailID gives customers mailID</param>
        public CustomerRegistration(string customerID,int walletBalance,string name,string fathersName,Gender gender,string mobile,DateTime dob,string mailID):base(name,fathersName,gender,mobile,dob,mailID)
        {
            CustomerID = customerID;
            s_cNumber = int.Parse(customerID.Remove(0,3));
            WalletBalance = walletBalance;
        }
        /// <summary>
        /// WalletRecharge method is used the amount to the total <see cref="CustomerRegistration"/>
        /// </summary>
        /// <param name="amount">amount give the value to add</param>
        public void WalletRecharge(int amount)
        {
            WalletBalance = WalletBalance + amount;
        }
    }
}