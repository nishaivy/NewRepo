using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Threading;

namespace AsynchronousProgramming2
{

    internal class Program
    {
        static Dictionary<string, int> di = new Dictionary<string, int>();
        /* List<int> L1=new List<int>();*/
        static async Task<Dictionary<string, int>> FirstMethod()
        {
            string a = "async";
            int b = 5;
            di.Add(a, b);
            di.Add("hello", 5);
            di.Add("world", 10);

            Console.WriteLine("1st method execution started");
            /*Thread.Sleep(5000);*/
            await Task.Delay(3000);
            Console.WriteLine("1st Method Execiton Completed");
            return di;

        }
        static void SecondMethod()
        {

            Console.WriteLine("2nd method execution started");
            Thread.Sleep(2000);
            Console.WriteLine("2nd Method Execiton Completed");
        }
        static async Task Main(string[] args)
        {
            /*FirstMethod();*/


            try
            {

                Task<Dictionary<string, int>> b = FirstMethod();
                SecondMethod();
                var c = await b;


                foreach (KeyValuePair<string, int> g in c)
                {
                    Console.WriteLine(g.Key + g.Value);
                }
                /*SecondMethod();*/
                /*Console.WriteLine(c.Keys + c.Values.ToString());*/
                /*SecondMethod();*/
                /* Console.WriteLine(b.Result);*/

                /*var c =await b;*/


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*SecondMethod();*/

            Console.ReadKey();
        }
    }
}