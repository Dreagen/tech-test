using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBestYet.DI
{
    public interface IPayment
    {
        void Pay();
    }

    public class Payment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Make a payment");
        }
    }

    public interface IPaymentFactory
    {
        IPayment Create();
    }

    public class PaymentFactory : IPaymentFactory
    {
        public IPayment Create()
        {
            return new Payment();
        }
    }

    public class VisaPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Make a Visa payment");
        }
    }

    public class CashPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Make a Cash payment");
        }
    }
}
