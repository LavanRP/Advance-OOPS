using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class FamilyInfo : PersonalInfo
    {
        //FatherName, MotherName, NoOfSiblings, NativePlace
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int NoOfSiblings { get; set; }
        public string NativePlace { get; set; }

        public FamilyInfo(string motherName,int noOfSiblings,string nativePlace)
        {
            this.FatherName = base.FatherName;
            MotherName = motherName; 
            NoOfSiblings = noOfSiblings;
            NativePlace = nativePlace;
        }
        public sealed override void Update(string name, string fatherName, string mobile, string mail, Gender gender )
        {
            base.Update(name, fatherName, mobile, mail, gender);
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Your name "+Name);
            Console.WriteLine("Your FatherName "+FatherName);
            Console.WriteLine("Your MotherName "+MotherName);
            Console.WriteLine("Your NoOfSiblings "+NoOfSiblings);
            Console.WriteLine("Your FatherName "+FatherName);
            Console.WriteLine("Your NativePlace "+NativePlace);
            Console.WriteLine("Your Mobile "+Mobile);
            Console.WriteLine("Your Gender "+Gender);
        }

    }
}