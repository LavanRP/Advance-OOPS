using System;
namespace Question2;
public class Program
{
    public static void Main(string[] args)
    {
        PatientInfo patientInfo = new PatientInfo("PID1001","Kumar","Raj",10,"Madurai","Fever");
        patientInfo.DisplayInfo();

        DoctorInfo doctor = new DoctorInfo(patientInfo.PatientID,patientInfo.Name,patientInfo.FatherName,patientInfo.BedNo,patientInfo.NativePlace,patientInfo.AdmittedFor,"Lavan","Ramesh","DID1001");
        doctor.DisplayInfo();
    }
}