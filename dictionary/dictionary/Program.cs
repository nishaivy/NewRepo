// C# program to listing the files in a directory
using System;
using System.IO;
using System.Threading.Tasks;

class dict
{

    static void Main(string[] args)
    {
        Console.Write("filename: ");
        string Username = (Console.ReadLine());
        string fileName = Username + ".txt";
      
        try
        {
            //Pass the filepath and filename to the StreamWriter Constructor
            //string path = System.IO.Path.Combine(@"C:\Users\nisha.hiremani\source\repos\day12\dictionary", fileName);
            StreamWriter sw = new StreamWriter("C:\\Users\\nisha.hiremani\\source\\repos\\day12\\dictionary\\"+fileName+".txt");
            //Write a line of text

            Console.Write("name: ");
            sw.WriteLine(Console.ReadLine());

            Console.Write("age: ");
            sw.WriteLine(Console.ReadLine());
           
            Console.Write("Place of origin:");
            sw.WriteLine(Console.ReadLine());

            Console.Write("Languages:");
            sw.WriteLine(Console.ReadLine());
            //Close the file
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally wriiten the data.");
        }

    }
}
