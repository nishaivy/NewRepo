using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lambadas_Expression
{
    class Program
    {
        public delegate void SimpleIn(double p, double r, double t);
        static void Main(string[] args)
        {
           
            SimpleIn s = delegate (double p, double r, double t)
             {
                 double si;
                 //calculate simple interest
                 si = p * r * t / 100;
                 Console.Write("Simple interest= " + si + "\n");
             };

            //take input of principal, interest rate and time
            Console.Write("Enter principal amount= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter interest rate= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter years= ");
            double c = Convert.ToDouble(Console.ReadLine());
            s.Invoke(a, b, c);
            Console.ReadKey();
        }
    }

}
