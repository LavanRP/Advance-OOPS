using System;

namespace Question1
{
    public partial class EmployeeInfo
    {
        //Update, Display
        public void Display()
        {
            Console.WriteLine("your Employee ID "+EmployeeID);
            Console.WriteLine("your Name "+Name);
            Console.WriteLine("your Gender "+Gender);
            Console.WriteLine("your DOB "+DOB);
            Console.WriteLine("your Mobile "+Mobile);
        }

        public void Update(string str)
        {
            Console.WriteLine("Mobile number updated");
            Mobile = str;
        }
    }
}