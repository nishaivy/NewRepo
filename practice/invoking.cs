using System;

namespace MyApplication
{
    class myClass
    {
        public void multiply(int x, int y)
        {
            int res = x * y;
            Console.WriteLine(res);
        }

        public static void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            myClass m = new myClass();
            m.multiply(4, 6);
            myClass.div(6,3);

            Console.ReadKey();
        }

}
}
  
