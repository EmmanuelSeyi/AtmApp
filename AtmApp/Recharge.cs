using System;
using System.Collections.Generic;
using System.Text;

namespace AtmApp
{
    class Recharge:Transfer
    {
        public long number { get; set; }
        public int creditAmount { get; set; }

        public void credit() {
            Console.WriteLine("\n1.Self Recharge\n2.Other Phone Numer");
            Console.WriteLine("Enter any option:");
            int option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\nEnter Amount:");
                    creditAmount = Int32.Parse(Console.ReadLine());
                    balance = amount - creditAmount;
                    Console.WriteLine("\nThe Credit transfer of " + creditAmount + " " + "to your number(" + phoneNumber + ") was Successful!");
                    Console.WriteLine("\nYour Balance is " + balance);
                    amount = balance;
                    break;
                case 2:
                    Console.WriteLine("\nEnter Phone Number:");
                    number = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter Amount:");
                    creditAmount = Int32.Parse(Console.ReadLine());
                    balance = amount - creditAmount;
                    Console.WriteLine("\nThe Credit transfer of " + creditAmount + " " + "to your number(" + number + ") was Successful!");
                    Console.WriteLine("\nYour Balance is " + balance);
                    amount = balance;
                    break;
                   
            }
           
        }
    }
}
