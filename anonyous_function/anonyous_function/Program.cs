using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lambadas_Expression
{
    class Program
    {
        public delegate void SimpleIn(double x, double y, double z);
        static void Main(string[] args)
        {
           //Lambda exp 1)statement lambda
          
            SimpleIn s =  ( p, r, t)=>
             {
                 double si;
                 
                 //calculate simple interest
                 si = p * r * t / 100;
               Console.Write("Simple interest= " + si + "\n");
             };
            //2)sxpression lambda
             SimpleIn s =  ( p, r, t)=> Console.WriteLine(p*r*t/100);
            // {
                // double si;
                 
                 //calculate simple interest
               //  si = p * r * t / 100;
                // Console.Write("Simple interest= " + si + "\n");
            // };

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
