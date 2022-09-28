using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace LambdaExpression
{

    // delegate ...  function pointer
    public delegate int cal(int a);  // single cast 
                                     //  public delegate int arithmatic(int a, int b);  // multicast 
    public delegate int find(int b, int c);
    public delegate void swap(int d, int e);
    public delegate void Sort(int[] arr1);
    internal class Program
    {
        // delegates.... function pointer ...
        // Anonymous function....  without name.... 2.0 
        static void Main(string[] args)
        {
            // Write a statement lambda to calculate sum of 1 to n number.
            Console.Write("The number are :\n");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            cal res = (p) =>
            {
                for (int j = 1; j <= n; j++)
                {
                    sum = sum + j;

                }
                return sum;
            };
            int result = res.Invoke(n);
            Console.WriteLine("sum is " + result);

            //Write an expression lambda to find greater between two numbers
            Console.WriteLine("Enter the first number b :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number c :");
            int c = Convert.ToInt32(Console.ReadLine());

            find grt = (p2, p3) => (b > c ? b : c);

            int res1 = grt.Invoke(b, c);

            Console.WriteLine("Greater num:" + res1);


            //Write an lambda expression to swap given two numbers.
            swap sp = (p4, p5) =>
            {
                b = b + c;

                c = b - c;
                b = b - c;



            Console.WriteLine($"Swap two numbers: b :{b}  c:{c}");
            };
            sp.Invoke(b, c);

            //Write an anonymous function to check given number is prime or not.
            Console.WriteLine("Enter prime number:");
            int d = Convert.ToInt32(Console.ReadLine());


            cal s = (p6) =>
            {
                for (int i = 2; i < d; i++)
                {
                    if (d % i == 0) return 0;


                }
                return 1;
            };
            int flag = s(d);

            if (flag == 1) Console.WriteLine($"{d} is Prime Number");
            else Console.WriteLine($"{d} is not Prime Number");


            //Write an lambda expression to sort given array.
            Console.WriteLine("Enter Size of Array:");
            int e = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[e];


            for (int i = 0; i < arr.Length; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                arr[i] = x;
            }
            Sort srt = (int[] arr2) =>
            {
                Array.Sort(arr);

                Console.WriteLine("Print Sorted Array: ");
                foreach (int i in arr)
                    Console.Write(i + " ");

                Console.WriteLine();
            };

            srt.Invoke(arr);

        }
    }
}
