using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public enum AccountType{Savings, Balance}
    public class SavingAccount : IDInfo,ICalculate,IBankInfo
    {
        private static int s_aNumber=121231;
        //AccountNumber, AccountType->Savings, Balance
        public String AccountNumber { get; set; }
        public AccountType AccountType{ get; set; }
        public int Balance{ get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }

        public SavingAccount(string name,Gender gender,DateTime dob,string phone,string voterID,string aadharID,string panNumber,string bankName,string ifsc,string branch,AccountType accountType,int balance):base(name,gender,dob,phone,voterID,aadharID,panNumber)
        {
            AccountNumber = "BAID"+s_aNumber;
            s_aNumber++;

            AccountType = accountType;
            Balance = balance;
            BankName = bankName;
            IFSC = ifsc;
            Branch = branch;
        }

        public void Deposit(int amount)
        {
            if(amount>0)
            {
                Balance = Balance + amount;
                Console.WriteLine($"Amount {amount} has been Deposit to your bank Account");
            }
            else
            {
                Console.WriteLine($"You can't Deposite {amount} amount");
            }
        }
        public void Withdraw(int amount)
        {
            if(amount<Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine($"Amount {amount} has been Withdraw from your bank Account");
            }
            else
            {
                Console.WriteLine("Insufficent Balance");
            }
        }
        public void BalanceCheck()
        {
            Console.WriteLine($"Your Balance: {Balance}");
        }
    }
}