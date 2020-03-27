using System;
using System.Collections.Generic;
using System.Text;

namespace AtmApp
{
    class Registration
    {
        public int pin { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public decimal amount { get; set; }
        public long phoneNumber { get; set; }

        

        public void Login() {
            pin = 0000;
            int inputPin;
            Console.WriteLine("Enter your pin");
            inputPin = Int32.Parse(Console.ReadLine());
            int inputLength = inputPin.ToString().Length;
           
            if ( inputLength > 4) {
                Console.WriteLine("THE PIN MUST BE 4 DIGITS!!!!!");
                Console.WriteLine("Enter your pin");
                inputPin = Int32.Parse(Console.ReadLine());
                
            }
            
            if (inputPin != pin) {
                Console.WriteLine("INCORRECT PIN!!!!!");
                Console.ReadKey();
                      }

            Console.WriteLine("First Name:");
            firstName=Console.ReadLine();

            Console.WriteLine("Last Name:");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter your Phone Numer");
            phoneNumber = long.Parse(Console.ReadLine());
            if (phoneNumber.ToString().Length > 11)
            {
                Console.WriteLine("THE PHONE NUMBER MUST BE 11 DIGITS!!!!!");
                 Console.WriteLine("Enter your Phone Numer");
                phoneNumber = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("How much are you depositing in your account:");
            amount = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Welcome "+firstName+" "+lastName+"\n");
            
            
        }
    }
}
