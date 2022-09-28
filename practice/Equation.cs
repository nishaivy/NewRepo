//Write a C# Sharp program to display certain values of the function z = a2 + 5a - 2 (using integer numbers for y , ranging from -5 to +5).
using System;
public class Equation
{
    public static void Main()
    {
        int z, a;
         
        Console.WriteLine("z = a2 + 5a - 2 ");
        Console.WriteLine();
         
        for (a=-5; a <= 5; a++)
        {
            int x=a*a;
            z = x+5*a-2;
            Console.WriteLine(
                "a = {0} ; z=({0}*{0})+5*({0}) -2 = {1}",
                a, z);
        }
    }
}


//output
// z = a2 + 5a - 2 
// a = -5 ; z=(-5*-5)+5*(-5) -2 = -2
// a = -4 ; z=(-4*-4)+5*(-4) -2 = -6
// a = -3 ; z=(-3*-3)+5*(-3) -2 = -8
// a = -2 ; z=(-2*-2)+5*(-2) -2 = -8
// a = -1 ; z=(-1*-1)+5*(-1) -2 = -6
// a = 0 ; z=(0*0)+5*(0) -2 = -2
// a = 1 ; z=(1*1)+5*(1) -2 = 4
// a = 2 ; z=(2*2)+5*(2) -2 = 12
// a = 3 ; z=(3*3)+5*(3) -2 = 22
// a = 4 ; z=(4*4)+5*(4) -2 = 34
// a = 5 ; z=(5*5)+5*(5) -2 = 48