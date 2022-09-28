using System;

namespace MyApplication
{
    class Myclass 
{
   public void Increase(ref int x)
    {
     x=x+1;
     }

    public void Equal(int y)
    {

    y=y+1;
   }
}

class Program
{
 static void Main(string[] args)
    {
     Myclass mcs = new Myclass();
    int x=20;
    int y=10;

    Console.WriteLine("The original value of the variable is:"+x);
    Console.WriteLine("The original value of the variable is:"+y);

   mcs.Increase(ref x);
   mcs.Equal(y);

Console.WriteLine("Value incremented by using By Reference for the variable x is:"+x); 
Console.WriteLine("The original value of the variable is:"+y);
Console.ReadKey();
}
}
}
  




//output:
// The original value of the variable is:20
// The original value of the variable is:10
// Value incremented by using By Reference for the variable x is:21
// The original value of the variable is:10