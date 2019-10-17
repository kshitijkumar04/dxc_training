using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankrecord
{
    class Bankrecord
    {
       public  int id, opening_balance, withdrawl_amt, deposit_amt, current_balance;
        public void accont_info(Bankrecord[] bank)
        {
           
            Console.WriteLine("Enter your ID");
            int p = int.Parse(Console.ReadLine());
            int j = p - 101;
            bank[j].current_balance = bank[j].opening_balance;
            string done="";
            while (done != "FINISH")
            {
                if (p > 100 && p < 106)
                {
                    Console.WriteLine("Welcome to Banking Service");
                    Console.WriteLine("Please Select your option");
                    Console.WriteLine("1. Current Balance");
                    Console.WriteLine("2.Deposit");
                    Console.WriteLine("3.Withdraw");
                    Console.WriteLine("4. Exit");

                }
                else
                {
                    Console.WriteLine("Please enter valid ID");
                }
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your current balance is: " + bank[j].current_balance);
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount to deposit");
                        bank[j].deposit_amt = int.Parse(Console.ReadLine());
                        bank[j].current_balance = bank[j].current_balance + bank[j].deposit_amt;
                        Console.WriteLine("Updated balance is: " + bank[j].current_balance);
                        break;
                    case 3:
                        if (bank[j].current_balance > 500)
                        {
                            Console.WriteLine("Enter amount to withdraw");
                            bank[j].withdrawl_amt = int.Parse(Console.ReadLine());
                            bank[j].current_balance = bank[j].current_balance - bank[j].withdrawl_amt;
                            Console.WriteLine("Updated balance is: " + bank[j].current_balance);
                        }
                        else
                        {
                            Console.WriteLine("Not enough balance");
                        }
                        break;
                    case 4:
                        done = "FINISH";
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
   
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bankrecord[] bank = new Bankrecord[5];
            Bankrecord bankrecord = new Bankrecord();
            bank[0] = new Bankrecord { id = 101,opening_balance=500,deposit_amt=0,withdrawl_amt=0,current_balance=0};
            bank[1] = new Bankrecord { id = 102, opening_balance = 500, deposit_amt = 0, withdrawl_amt = 0, current_balance = 0 };
            bank[2] = new Bankrecord { id = 103, opening_balance = 500, deposit_amt = 0, withdrawl_amt = 0, current_balance = 0 };
            bank[3] = new Bankrecord { id = 104, opening_balance = 500, deposit_amt = 0, withdrawl_amt = 0, current_balance = 0 };
            bank[4] = new Bankrecord { id = 105, opening_balance = 500, deposit_amt = 0, withdrawl_amt = 0, current_balance = 0 };
            bankrecord.accont_info(bank);
            Console.ReadLine();

        }
    }
}
