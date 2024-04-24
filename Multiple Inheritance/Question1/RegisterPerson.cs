using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class RegisterPerson : Personalnfo,IShowData,IFamilyInfo
    {
        //RegistrationNumber(Auto), DateOfRegistration
        private static int s_rNumber=1000;

        public string RegistrationNumber { get; set; }
        public DateTime DateOfRegistration{ get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSiblings { get; set; }

        public RegisterPerson(string name,Gender gender,DateTime dob,string phone, Maritaldetails maritaldetails,string fatherName,string motherName,string houseAddress,int noOfSiblings,DateTime dateOfRegistration):base(name,gender,dob,phone,maritaldetails)
        {
            RegistrationNumber = "RID"+s_rNumber;
            s_rNumber++;

            DateOfRegistration = dateOfRegistration;
            FatherName = fatherName;
            MotherName = motherName;
            HouseAddress = houseAddress;
            NoOfSiblings = noOfSiblings;
        }
        public void ShowInfo()
        {
            Console.WriteLine("-----Registration info-----");;
            Console.WriteLine($"Your RegistrationNumber: {RegistrationNumber}\nYour Date Of Registration: {DateOfRegistration}\nYour FatherName: {FatherName}\nYour MotherName: {MotherName}\nYour Marital NoOfSiblings: {NoOfSiblings}");
        }
    }
}