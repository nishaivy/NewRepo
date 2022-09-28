using System;
public class Triangle
{
  public static void Main()
  {
   Console.Write("Enter number: ");
   int num = Convert.ToInt32( Console.ReadLine() );
 
   Console.Write("width: ");
   int width = Convert.ToInt32( Console.ReadLine() );
 
   int height = width;   
   for (int row=0; row < height; row++)
   {
    for (int column=0; column < width; column++)
   {
   Console.Write( num );
  }
 
   Console.WriteLine();
   width--;
  }
 }
} 

//output
// Enter number: 4
// width: 4
// 4444
// 444
// 44
// 4