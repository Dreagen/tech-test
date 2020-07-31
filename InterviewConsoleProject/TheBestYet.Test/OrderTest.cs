using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBestYet.DI;

namespace TheBestYet.Test
{
    [TestClass]
    public class OrderTest
    {
        private Order _order;
        private PaymentFactoryMock _paymentFactoryMock;

        [TestInitialize]
        public void TestInitialize()
        {
            _paymentFactoryMock = new PaymentFactoryMock();
            _order = new Order(_paymentFactoryMock);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void CTR_NullPaymentFactory()
        {
            new Order(null);
        }

        //[TestMethod]
        //public void CTR()
        //{
        //    new Order(new PaymentFactoryMock());
        //}

        [TestMethod]
        public void MakePayment()
        {
            PaymentMock payment = new PaymentMock();
            _paymentFactoryMock.PendingPayments.Enqueue(payment);
            payment.ExpectedPayCalls = 1;

            _order.MakePayment();

            _paymentFactoryMock.VerifyExpectations();
            payment.VerifyExpectations();
        }


        private class PaymentFactoryMock : IPaymentFactory
        {
            public readonly Queue<PaymentMock> PendingPayments = new Queue<PaymentMock>();

            public IPayment Create()
            {
                return PendingPayments.Dequeue();
            }

            public void VerifyExpectations()
            {
                if (PendingPayments.Count != 0)
                {
                    throw new Exception("Not all pending payments were created.");
                }
            }

        }

        private class PaymentMock : IPayment
        {
            public int ExpectedPayCalls = 0;

            public void Pay()
            {
                if (ExpectedPayCalls <= 0)
                {
                    throw new Exception("Unexpected call of IPayment.Pay.");
                }

                --ExpectedPayCalls;
            }

            public void VerifyExpectations()
            {
                if (ExpectedPayCalls != 0)
                {
                    throw new Exception("Not all pending payments were payed.");
                }
            }
        }
    }
}
