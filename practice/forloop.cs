using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         for (int a = 10; a <= 100; a = a * 2) {
            Console.WriteLine("value of a: {0}", a);
         }
        Console.ReadLine();
      }
   }
} 