using System;
namespace Question2;
public class Program
{
    public static void Main(string[] args)
    {
        SavingAccount account1 = new SavingAccount("lavan",Gender.Male,new DateTime(2002,05,12),"12345","INDV432","987654321","PAN5432","HDFC","HDFC0000022","madurai",AccountType.Savings,10000);
        SavingAccount account2 = new SavingAccount("kumar",Gender.Male,new DateTime(2001,07,11),"576543","INDV892","98345678","PAN5541","HDFC","HDFC0003324","madurai",AccountType.Savings,20000);

        account1.Withdraw(1000);
        Console.WriteLine();
        account1.Deposit(2000);
        Console.WriteLine();
        account1.BalanceCheck();
        Console.WriteLine();

        account2.Withdraw(2000);
        Console.WriteLine();
        account2.Deposit(3000);
        Console.WriteLine();
        account2.BalanceCheck();
        Console.WriteLine();
    }
}