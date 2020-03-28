using System;
using System.Collections.Generic;
using System.Text;

namespace AtmApp
{
    class BillPayment : Recharge
    {
        public decimal dstvAccess { get; set; }
        public decimal dstvFamily { get; set; }
        public int prepaidCode { get; set; }
        public string smartCardNumber { get; set; }
        public string meterNumber { get; set; }
        public string userId { get; set; }
        public void bills()
        {
            Random r = new Random();
            int genRand = r.Next(10, 5000);
            dstvAccess = 4000;
            dstvFamily = 3000;
            Console.WriteLine("1.DSTV\n2.Prepaid Metre\n3.Swift Internet Services");
            Console.WriteLine("Enter any option:");
            int option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int subscription;
                    Console.WriteLine("1.DSTV Family \n2.DSTV Access");
                    Console.WriteLine("Select Plan:");
                    subscription = Int32.Parse(Console.ReadLine());
                    if (subscription == 1)
                    {
                        Console.WriteLine("Enter your Smart Card Numer");
                        smartCardNumber = Console.ReadLine();
                        while(smartCardNumber.Length != 11)
                        {
                            Console.WriteLine("THE SMART CARD NUMBER MUST BE 11 DIGITS!!!!!");
                            Console.WriteLine("Enter your Smart Card Numer");
                            smartCardNumber= Console.ReadLine();
                        }
                        if (dstvFamily > amount)
                        {
                            Console.WriteLine(" INSUFFICIENT FUNDS");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        balance = amount - dstvFamily;
                        amount = balance;
                        Console.WriteLine("\nYour Dstv Family plan Subscription of #" + dstvFamily + " " + "to " + smartCardNumber + " was Successful!");
                        Console.WriteLine("\nYour Balance is #" + balance);
                    }
                    else if (subscription == 2)
                    {
                        Console.WriteLine("Enter your Smart Card Numer");
                        smartCardNumber = Console.ReadLine();
                        while (smartCardNumber.Length != 11)
                        {
                            Console.WriteLine("THE SMART CARD NUMBER MUST BE 11 DIGITS!!!!!");
                            Console.WriteLine("Enter your Smart Card Numer");
                            smartCardNumber = Console.ReadLine();
                        }
                        if (dstvAccess > amount)
                        {
                            Console.WriteLine(" INSUFFICIENT FUNDS");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        balance = amount - dstvAccess;
                        amount = balance;
                        Console.WriteLine("\nYour Dstv Access plan Subscription of #" + dstvAccess + " " + "to " + smartCardNumber + " was Successful!");
                        Console.WriteLine("\nYour Balance is " + balance);

                    }
                    break;
                case 2:
                    Console.WriteLine("\nEnter your Meter Cardnumber:");
                    meterNumber = Console.ReadLine();
                    while(meterNumber.ToString().Length != 11)
                    {
                        Console.WriteLine("THE METER CARD NUMBER MUST BE 11 DIGITS!!!!!");
                        Console.WriteLine("\nEnter your Meter Cardnumber:");
                        meterNumber = Console.ReadLine();
                    }
                    Console.WriteLine("\nEnter Amount:");
                    int credit = Int32.Parse(Console.ReadLine());
                    if (credit > amount)
                    {
                        Console.WriteLine(" INSUFFICIENT FUNDS");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    balance = amount - credit;
                    amount = balance;

                    Console.WriteLine("\nYour Pre-Paid Meter Card Purchase of #" + credit + " " + "to " + meterNumber + " was Successful!");
                    Console.WriteLine("Your Pre-Paid Meter Card code is " + genRand);
                    Console.WriteLine("\nYour Balance is #" + balance);
                    break;

                case 3:
                    Console.WriteLine("\nEnter your Swift Id:");
                    userId = Console.ReadLine();
                    while (userId.Length !=6)
                    {
                        Console.WriteLine("THE USER ID MUST BE 6 DIGITS!!!!!");
                        Console.WriteLine("\nEnter your Swift Id:");
                        userId = Console.ReadLine();
                    }
                    Console.WriteLine("\nEnter Amount:");
                    int swiftCredit = Int32.Parse(Console.ReadLine());
                    if (swiftCredit > amount) 
                    {
                        Console.WriteLine(" INSUFFICIENT FUNDS");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    balance = amount - swiftCredit;
                    amount = balance;

                    Console.WriteLine("\nYour Swift Internet Service  Purchase of #" + swiftCredit + " " + "to " + userId + " was Successful!");
                    Console.WriteLine("\nYour Balance is #" + balance);
                    break;


            }
        }
    }
}