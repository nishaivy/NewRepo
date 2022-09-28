using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         int a = 10;
         do {
            Console.WriteLine("value of a: {0}", a);
            a=a+1;
         } 
         while (10<=a &&a < 15);
         
         Console.WriteLine("do loop terminated");
        Console.ReadLine();
      }
   }
}