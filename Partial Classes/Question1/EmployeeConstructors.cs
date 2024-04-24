using System;

namespace Question1
{
    public partial class EmployeeInfo
    {
        public EmployeeInfo(string employeeID,string name,Gender gender,DateTime dob,string mobile)
        {
            EmployeeID = employeeID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
        }
    }
}