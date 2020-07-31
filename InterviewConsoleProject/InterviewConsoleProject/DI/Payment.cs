using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewConsoleProject.DI
{
    public class Payment
    {
        public void Pay()
        {
            Console.WriteLine("Payment");
        }
    }

    public class VisaPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment Visa");
        }
    }

    public class CashPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment Cash");
        }
    }
}
