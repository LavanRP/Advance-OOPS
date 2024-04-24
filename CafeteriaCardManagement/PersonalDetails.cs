using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// Gender it is public Enum which has the following values{Select, Male, Female, Transgender} <see cref="PersonalDetails"/>
    /// </summary>
    public enum Gender {Select, Male, Female, Transgender}
    /// <summary>
    /// PersonalDetails class holds all the personal information about the user <see cref="PersonalDetails"/> 
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// Name is a public property used to store user name <see cref="PersonalDetails"/>
        /// </summary> 
        public string Name { get; set; }  
        /// <summary>
        /// FatherName is a public property used to store user FatherName <see cref="PersonalDetails"/>
        /// </summary> 
        public string FatherName { get; set; } 
        /// <summary>
        /// Gender is a public property used to store user Gender <see cref="PersonalDetails"/>
        /// </summary>  
        public Gender Gender { get; set; }  
        /// <summary>
        /// Mobile is a public property used to store user Mobile number <see cref="PersonalDetails"/>
        /// </summary> 
        public string Mobile { get; set; } 
        /// <summary>
        /// MailID is a public property used to store user MailID <see cref="PersonalDetails"/>
        /// </summary> 
        public string MailID { get; set; } 
        /// <summary>
        /// PersonalDetails it is a constructor used to asign value. <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name">name is used to store value in Name</param>
        /// <param name="fatherName">fatherName is used to store value in FatherName</param>
        /// <param name="mobile">mobile is used to store value in Mobile</param>
        /// <param name="mailID">mailID is used to store value in MailID</param>
        /// <param name="gender">gender is used to store value in Gender</param>
        public PersonalDetails(string name,string fatherName,Gender gender,string mobile,string mailID)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            MailID = mailID;
        }
    }
}