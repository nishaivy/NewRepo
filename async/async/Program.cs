using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class Program
    {
        static async void FirstMethod()
        {
            Console.WriteLine("1st method execution started");
            /*thread.sleep(5000);*/
            await Task.Delay(1000);
            Console.WriteLine("1st method execiton completed");
        }
        static void SecondMethod()
        {

            Console.WriteLine("2nd method execution started");
            /*  await Task.Delay(2000);*/
            Console.WriteLine("2nd Method Execiton Completed");
        }
        static async Task Main(string[] args)
        {
            FirstMethod();

            SecondMethod();

            Console.ReadKey();
        }
    }
}
