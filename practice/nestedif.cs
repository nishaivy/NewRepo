using System;
class Program
   {
   static void Main(string[] args)
   {
      int a = -1,b = 10, c;
      
      if (a < 0 && b < 0)
      {
         Console.WriteLine("Both a and b are negative.");
      }
      else if (a < 0 || b < 0)
      {
         if (b > 0 && b <= 10)
         {
            c = a + b;
            Console.WriteLine("addition: {0}", c);
         }
      Console.WriteLine("One number is negative.");
      }
   else
   {
      Console.WriteLine("Both numbers are positive.");
      }
 
  }
}