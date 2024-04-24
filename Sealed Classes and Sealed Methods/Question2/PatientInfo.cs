using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public sealed class PatientInfo
    {
        //PatientID, Name, FatherName, BedNo, NativePlace, AdmittedFor
        public string PatientID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int BedNo { get; set; }
        public string NativePlace { get; set; }
        public string AdmittedFor { get; set; }
        
        public PatientInfo(string patientID,string name,string fatherName,int bedNo,string nativePlace,string admittedFor)
        {
            PatientID = patientID;
            Name = name;
            FatherName = fatherName;
            BedNo = bedNo;
            NativePlace = nativePlace;
            AdmittedFor = admittedFor;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Your PatientID "+PatientID);
            Console.WriteLine("Your Name "+Name);
            Console.WriteLine("Your BedNo "+BedNo);
            Console.WriteLine("Admitted For "+AdmittedFor);
        }
        
    }
}