using System;
public class Reverse
{
  public static void Main()
  {  
    char l1,l2,l3;
  
    Console.Write("letter 1: ");
    l1 = Convert.ToChar(Console.ReadLine());
 
    Console.Write("letter 2: ");
    l2 = Convert.ToChar(Console.ReadLine());       
 
    Console.Write("letter 3: ");
    l3 = Convert.ToChar(Console.ReadLine());
     
    Console.WriteLine("{0} {1} {2}",l3,l2,l1);
   }
}
//
//output
// letter 1: w
// letter 2: r
// letter 3: h
// h r w