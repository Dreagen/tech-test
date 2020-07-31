using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBestYet.DI
{
    public class Order
    {
        private readonly IPaymentFactory _paymentFactory;

        public Order(IPaymentFactory paymentFactory)
        {
            if (paymentFactory == null)
            {
                throw new ArgumentNullException("The payment factory cannot be null.");
            }

            _paymentFactory = paymentFactory;
        }

        public void MakePayment()
        {
            IPayment payment = _paymentFactory.Create();
            payment.Pay();
        }
    }
}
