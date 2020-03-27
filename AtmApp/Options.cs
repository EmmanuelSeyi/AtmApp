using System;
using System.Collections.Generic;
using System.Text;

namespace AtmApp
{
    class Options : BillPayment
    {
        public int option { get; set; }
        public void select()
        {



            Login();

            Console.WriteLine("1.Transfer\n2.Recharge\n3.Pay your Bills\n0.Exit");
            Console.WriteLine("Enter any option:");
            option = Int32.Parse(Console.ReadLine());
            while (option != 0)
            {
                switch (option)
                {
                    case 1:
                        transaction();

                        break;
                    case 2:
                        credit();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("\n1.Transfer\n2.Recharge\n3.Pay your Bills\n0.Exit");
                Console.WriteLine("Enter any option:");
                option = Int32.Parse(Console.ReadLine());
            }


        }
    }
}
    