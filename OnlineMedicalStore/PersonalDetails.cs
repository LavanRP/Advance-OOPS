using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// PersonalDetails this class holds all the personal details of the user<see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// Name is property used to store and get users name<see cref="PersonalDetails"/>
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Age is property used to store and get users Age<see cref="PersonalDetails"/>
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// City is property used to store and get users City<see cref="PersonalDetails"/>
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Phonenumber is property used to store and get users Phonenumber<see cref="PersonalDetails"/>
        /// </summary>
        public string Phonenumber { get; set; }
        /// <summary>
        /// this constructor is used to asigne values to the property<see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name">names gives user name</param>
        /// <param name="age">age gives user age</param>
        /// <param name="city">city gives user city</param>
        /// <param name="phonenumber">phonenumber gives user phonenumber</param> 
        public PersonalDetails(string name ,int age,string city,string phonenumber)
        {
            Name = name;
            Age = age;
            City = city;
            Phonenumber = phonenumber;

        }
        
    }
}