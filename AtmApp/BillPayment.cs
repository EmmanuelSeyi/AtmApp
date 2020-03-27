using System;
using System.Collections.Generic;
using System.Text;

namespace AtmApp
{
    class BillPayment:Recharge
    {
       public decimal dstvAccess { get; set; }
        public decimal dstvFamily { get; set; }
        public int prepaidCode { get; set; }
        

    }
}
