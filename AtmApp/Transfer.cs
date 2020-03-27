using System;
using System.Collections.Generic;
using System.Text;

namespace AtmApp
{
    class Transfer : Registration
    {

        public long destinationAccNumber { get; set; }
        public decimal transferAmount { get; set; }
        public decimal balance { get; set; }
        public void transaction()
        {

            Console.WriteLine("\nEnter destination account number:");
            destinationAccNumber = long.Parse(Console.ReadLine());
            if (destinationAccNumber.ToString().Length > 11)
            {
                Console.WriteLine("THE ACCOUNT MUST BE 11 DIGITS!!!!!");
                Console.WriteLine("\nEnter your Phone Numer");
                destinationAccNumber = long.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEnter Amount:");
            transferAmount = Int32.Parse(Console.ReadLine());
            if (transferAmount > amount)
            {
                Console.WriteLine(amount + " INSUFFICIENT FUNDS");
                Console.ReadKey();
                Environment.Exit(0);
            }
            balance = amount - transferAmount;
            Console.WriteLine("\nThe transfer of "+transferAmount+" "+"to "+destinationAccNumber+" was Successful!");
            Console.WriteLine("\nYour Balance is "+balance);
            amount = balance;
          
        }
    }
}