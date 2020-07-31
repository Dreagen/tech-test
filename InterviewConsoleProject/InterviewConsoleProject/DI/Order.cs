using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewConsoleProject.DI
{
    public class Order
    {
        private int _paymentsMade = 0;

        public void MakePayment()
        {
            Payment payment = new Payment();
            payment.Pay();
            _paymentsMade++;
        }

        public int PaymentsMade
        {
            get { return _paymentsMade; }
        }
    }
}
