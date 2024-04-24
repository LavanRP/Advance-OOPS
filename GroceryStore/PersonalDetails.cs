using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    /// <summary>
    /// Gender is an enum which has following values {Male,Female,Others}<see cref="PersonalDetails"/>
    /// </summary>
    public enum Gender { Male, Female, Others }
    /// <summary>
    /// PersonalDetails class holds all the information about customer PersonalDetails<see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// Name is used to store and get customer Name<see cref="PersonalDetails"/>
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// FathersName is used to store and get customer FathersName<see cref="PersonalDetails"/>
        /// </summary>
        public string FathersName { get; set; }
        /// <summary>
        /// Gender is used to store and get customer Gender<see cref="PersonalDetails"/>
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Mobile is used to store and get customer Mobile<see cref="PersonalDetails"/>
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// DOB is used to store and get customer DOB<see cref="PersonalDetails"/>
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// MailID is used to store and get customer MailID<see cref="PersonalDetails"/>
        /// </summary>
        public string MailID { get; set; }
        /// <summary>
        /// this constructor is used to store assigne values to the property<see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name">name gives users name</param>
        /// <param name="fathersName">fathersName gives users fathersName</param>
        /// <param name="gender">gender gives users gender</param>
        /// <param name="mobile">mobile gives users mobile number</param>
        /// <param name="dob">dob gives users dob</param>
        /// <param name="mailID">mailID gives users mailID</param>
        public PersonalDetails(string name, string fathersName, Gender gender, string mobile, DateTime dob, string mailID)
        {
            Name = name;
            FathersName = fathersName;
            Gender = gender;
            Mobile = mobile;
            DOB = dob;
            MailID = mailID;
        }
    }
}