using System;
namespace Question3;
public class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employeeInfo = new EmployeeInfo("Rani",2,"madurai","EID1001",new DateTime(2024,04,21));
        employeeInfo.Update("lavan","ramesh","1234567","lavan@gmail.com",Gender.male);
        employeeInfo.DisplayInfo();
    }
}