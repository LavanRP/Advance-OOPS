using System;

namespace Question1
{
    public enum Gender{male,female,others}
    public partial class EmployeeInfo 
    {
        //EmployeeID,Name,Gender,DOB, Mobile
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Mobile { get; set; }
    }
}