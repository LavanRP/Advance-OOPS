using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// UserDetails class holds all the information about user<see cref="UserDetails"/>
    /// </summary> 
    public class UserDetails : PersonalDetails, IBalance
    {
        /// <summary>
        /// _balance it is a public field used to get and store balance from user<see cref="UserDetails"/>
        /// </summary>
        public int _balance;
        /// <summary>
        /// _sNumber is a private static field used for auto increment in  UserID <see cref="UserDetails"/>
        /// </summary>
        private static int _sNumber = 1001;
        /// <summary>
        /// UserID properties hold User's ID  of instance of <see cref="UserDetails"/>
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// WorkStationNumber properties hold WorkStationNumber of instance of <see cref="UserDetails"/>
        /// </summary>
        public string WorkStationNumber { get; set; }
         /// <summary>
        /// WorkStationNumber properties hold WalletBalance of instance of <see cref="UserDetails"/>
        /// </summary>
        public int WalletBalance { get { return _balance; } }
        /// <summary>
        /// this is an constructer used to assigne values to properties <see cref="UserDetails"/>
        /// </summary>
        /// <param name="name">name is used to store value in Name</param>
        /// <param name="fatherName">fatherName is used to store value in FatherName</param>
        /// <param name="mobile">mobile is used to store value in Mobile</param>
        /// <param name="mailID">mailID is used to store value in MailID</param>
        /// <param name="gender">gender is used to store value in Gender</param>
        /// <param name="workStationNumber">workStationNumber is used to store value in WorkStationNumber</param>
        /// <param name="balance">balance is used to store value in balance</param>
        /// <returns></returns>
        public UserDetails(string name, string fatherName, string mobile, string mailID, Gender gender, string workStationNumber, int balance) : base(name, fatherName, gender, mobile, mailID)
        {
            UserID = "SF" + _sNumber;
            _sNumber++;
            WorkStationNumber = workStationNumber;
            _balance = balance;
        }
        /// <summary>
        /// WalletRecharge public method gets parameter a int value and add it to the  balance
        /// </summary>
        /// <param name="amount">amount it is a int value that user want to add it to balance </param> 
        public void WalletRecharge(int amount)
        {
            _balance = _balance + amount;
        }
        /// <summary>
        /// DeductAmount is a public method used to detuct amount from the user balance 
        /// </summary>
        /// <param name="amount">amount it is a int value that user want to remove it from balance</param>
        public void DeductAmount(int amount)
        {
            _balance = _balance - amount;
        }

    }
}