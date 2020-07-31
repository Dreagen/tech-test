using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterviewConsoleProject.DI;
using System.IO;

namespace InterviewConsoleProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Order o = new Order();
            o.MakePayment();

            Console.Read();
        }
    }
}
