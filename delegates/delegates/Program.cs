// C# program to illustrate the use of Delegates
using System;
using System.Security.Cryptography.X509Certificates;

namespace Delegates
{

    delegate void MyDel(int num);
    class Sample
    {
        static void CalculateFactorial(int num)
        {
            int fact = 1;

            for (int i = 2; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact); ;
        }
        //static void FibonacciSeries(int a)
        //{
        //    int n1 = 0, n2 = 1, result1 = 0;
        //    if (a == 0) Console.WriteLine(0);
        //    if (a == 1) Console.WriteLine(  1);

        //    for (int y = 2; y <= a; y++)
        //    {
        //        result1 = n1 + n2;
        //        n1 = n2;
        //        n2 = result1;
        //    }
        //    Console.WriteLine(result1);

        //}
         static void FibonacciNumber(int a)
        {
            if ((a == 0) || (a == 1))
            {
                Console.WriteLine(a);
            }
            
        
        }
        static void PrintFactors(int b)
        {
            int j = 0;
            Console.WriteLine("The all factors of " + b + " are :");

            for (j = 1; j <= b; j++)
            {
                if (b % j == 0)
                {
                    Console.Write(j + " ");
                }
            }
        }
        static void table(int n3)
        {
            int x;
            Console.Write("Multiplication table {0} \n", n3);
            for (x = 1; x <= 10; x++)
            {
                Console.Write("{0} X {1} = {2} \n", n3, x, n3 * x);
            }
        }

        static void Main()
        {
            int result = 0;
            int number = 0;

            MyDel del = new MyDel(CalculateFactorial);

            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());

             del(number);

            Console.WriteLine("Factorial of number {0} is: {1}", number, result);

            Console.Write("Enter the nth number of the Fibonacci Series: ");
            int num = Convert.ToInt32(Console.ReadLine());
            num = num- 1;
            //We have to decrement the length because the series starts with 0  
            del = FibonacciNumber;
            del(num);
            


            int b;
                Console.Write("Enter an factor number: ");
                b = int.Parse(Console.ReadLine());
               del = PrintFactors;
               del(b);
              


                //tables 
                int c;
                Console.Write("Input upto the table number starting from 1 : ");
                c = Convert.ToInt32(Console.ReadLine());
            del = table;
            del(c);
                
                Console.Write("\n");
            }
        }
    }



