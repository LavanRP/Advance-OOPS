using System;
using Question2;
namespace Question;
public class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal1 = new PersonalInfo("lavan","ramesh","12345","lavan@gmail.com",new DateTime(2002,05,12),Gender.Male);
        PersonalInfo personal2 = new PersonalInfo("kumar","kishore","54322","kumar@gmail.com",new DateTime(2002,09,01),Gender.Male);
        PersonalInfo personal3 = new PersonalInfo("priya","ramesh","765432","priya@gmail.com",new DateTime(2002,07,02),Gender.Female);

        AccountInfo account1 = new AccountInfo(personal1.Name,personal1.FatherName,personal1.Phone,personal1.Mail,personal1.DOB,personal1.Gender,"madurai branch","SDI1234",10000);
        AccountInfo account2 = new AccountInfo(personal2.Name,personal2.FatherName,personal2.Phone,personal2.Mail,personal2.DOB,personal2.Gender,"chennai branch","SDI4321",20000);
        AccountInfo account3 = new AccountInfo(personal3.Name,personal3.FatherName,personal3.Phone,personal3.Mail,personal3.DOB,personal3.Gender,"madurai branch","SDI6543",30000);

        account1.ShowAccountInfo();
        Console.WriteLine();
        account1.Deposit(1000);
        Console.WriteLine();
        account1.Withdraw(100);
        Console.WriteLine();
        account1.ShowBalance();
        Console.WriteLine("--------------------------------------");
        account2.ShowAccountInfo();
        Console.WriteLine();
        account2.Deposit(1000);
        Console.WriteLine();
        account2.Withdraw(100);
        Console.WriteLine();
        account2.ShowBalance();
        Console.WriteLine("--------------------------------------");
        account3.ShowAccountInfo();
        Console.WriteLine();
        account3.Deposit(1000);
        Console.WriteLine();
        account3.Withdraw(100);
        Console.WriteLine();
    }
}