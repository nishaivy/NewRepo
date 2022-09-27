//In a C# program, open a file from a directory and display the contents on screen. For this program, write atleast 3 specific exceptions and display the appropriate error msg on screen.
using System;
using System.Reflection;

//Exception handling using try-catch blocks
class Exception_handling { 
public static void Main()
{
        try
        {
            Console.WriteLine("Enter a number: ");

            var num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Squre of {num} is {num * num}");

        }
        catch (Exception ex)
        {
            Console.Write("Error info:" + ex.Message);
        }

        finally
        {
            Console.Write("Re-try with a different number.");
        }

        //Exception Filters
        Console.Write("\nPlease enter a number to divide 100: ");
        try
        {
            int num = int.Parse(Console.ReadLine());

            int result = 100 / num;

            Console.WriteLine("100 / {0} = {1}", num, result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero. Please try again.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Invalid operation. Please try again.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Not a valid format. Please try again.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred! Please try again.\n");
        }
       
        //nested try-catch
        var divider = 0;

        try
        {
            try
            {
                var result = 100 / divider;
            }
            catch (Exception ex)
            {
                Console.Write("\ninner Catch\n" + ex.Message);
            }
        }
        catch (Exception ex)
        {
            Console.Write("\nOuter Catch\n" + ex.Message);
        }

    }
}

//Output:
//Enter a number:
//12
//Squre of 12 is 144
//Re-try with a different number.
//Please enter a number to divide 100: 12
//100 / 12 = 8

//inner Catch
//Attempted to divide by zero.