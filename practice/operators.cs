using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //
      int A = 6;
      int B=++A;
      int C=--A;
      Console.WriteLine("Increment {0}",B); 
      Console.WriteLine("Decrement {0}",C); 
      
      
      //arithmetic
      int x = 5;
      int y = 3;
      Console.WriteLine("x+y= {0}",x + y);
      Console.WriteLine("x-y= {0}",x - y); 
      Console.WriteLine("x*y= {0}",x * y); 
      Console.WriteLine("x/y= {0}",x / y); 
      Console.WriteLine("x%y= {0}",x %y); 
      
      //assignment
      int z = 6,a=6,b=6,c=6,d=6,e=6,f=6,g=6,h=6,i=6;
       Console.WriteLine("+= -->{0}",z+=2); 
       Console.WriteLine("-= -->{0}",a -= 2);
       Console.WriteLine("*= -->{0}",b *= 2);
       Console.WriteLine("/= -->{0}",c /= 2);
       Console.WriteLine("%= -->{0}",d %= 2);
       Console.WriteLine("&= -->{0}",e &= 2);
       Console.WriteLine("|= -->{0}",f |= 2);
       Console.WriteLine("^= -->{0}",g ^= 2);
       Console.WriteLine("<<= -->{0}",h <<= 2);
       Console.WriteLine(">>= -->{0}",i >>= 2);
       
       string S1=null;
       Console.WriteLine(S1??"right");
       
     }
  }
}