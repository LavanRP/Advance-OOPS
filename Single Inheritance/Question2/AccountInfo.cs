using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class AccountInfo : PersonalInfo
    {
        private static int s_number=11223300;
        public int AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public int Balance { get; set; }

        public AccountInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,string branchName,string ifscCode,int balance):base(name,fatherName,phone,mail,dob,gender)
        {
            AccountNumber=s_number;
            s_number++;
            BranchName = branchName;
            IFSCCode = ifscCode;
            Balance = balance;
        }
        public void ShowAccountInfo()
        {
            Console.WriteLine("Your Name: "+Name);
            Console.WriteLine("Your FatherName: "+FatherName);
            Console.WriteLine("Your Phone Number: "+Phone);
            Console.WriteLine("Your Mail ID: "+Mail);
            Console.WriteLine("Your DOB: "+DOB);
            Console.WriteLine("Your Gender: "+Gender);
            Console.WriteLine("Your AccountNumber: "+AccountNumber);
            Console.WriteLine("Your BranchName: "+BranchName);
            Console.WriteLine("Your IFSCCode: "+IFSCCode);
            Console.WriteLine("Your Balance: "+Balance);
        }
        public void Deposit(int amount)
        {
            if(amount>0)
            {
                Balance=Balance+amount;
                Console.WriteLine("amount has been Deposited");
            }
            else
            {
                Console.WriteLine($"you cant deposit {amount} amount");
            }
        }
        public void Withdraw(int amount)
        {
            if(amount<=Balance)
            {
                Balance=Balance-amount;
                Console.WriteLine("amount has been withdrawed");
            }
            else
            {
                Console.WriteLine("Insufficent Balance");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine($"you bank balance: {Balance}");
        }
    }
}