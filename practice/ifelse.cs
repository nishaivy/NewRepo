using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        int A = 4;
        if (A%2==0)
        {
            if (A == 2)
                Console.WriteLine("A is the only even prime number");
            else
                Console.WriteLine("A is an even number");
            if(A%3==0)
                Console.WriteLine("A is multiple of 6");
            else if(A%5==0)
                Console.WriteLine("A is multiple of 10");
            else
            Console.WriteLine("A is odd number");
}
}
}
}