using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class DoctorInfo : PatientInfo
    {
        //DoctorID, Name, FatherName
        public string DoctorID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }

        public DoctorInfo(string patientID,string name,string fatherName,int bedNo,string nativePlace,string admittedFor,string name1,string fatherName1,string docterID): base(patientID,name,fatherName,bedNo,nativePlace,admittedFor)
        {
            this.Name = name1;
            this.FatherName = fatherName1;
            DoctorID = docterID;
        } 
        public void DisplayInfo()
        {
            Console.WriteLine("Your PatientID "+PatientID);
            Console.WriteLine("Your Name "+Name);
            Console.WriteLine("Your BedNo "+BedNo);
            Console.WriteLine("Admitted For "+AdmittedFor);
            Console.WriteLine("Your DoctorID "+DoctorID);
            Console.WriteLine("Your Doctor Name "+this.Name);
            Console.WriteLine("Your FatherName "+this.FatherName);
        }
    }
}