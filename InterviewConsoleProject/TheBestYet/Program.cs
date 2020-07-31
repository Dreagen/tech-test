using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheBestYet.DI;

namespace TheBestYet
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRepository pr = new PersonRepository();
            List<Person> people = pr.GetPeople();

            people.ForEach(
                delegate(Person person)
                {
                    Console.WriteLine(person.ToString());
                });

            people.ForEach(per => Console.WriteLine(per.ToString()));

            //IPaymentFactory paymentFactory = new PaymentFactory();

            //Order order = new Order();
            //order.MakePayment(paymentFactory);

            Console.Read();
        }
    }
}
