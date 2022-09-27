// C# program to copy data from one file to another
//Write a C# program to copy the contents of one file to another file and move that file to a different location.

using System;
using System.IO;

class Copy_File
{

    static void Main()
    {

        // Copy contents from file1 to file2
        File.Copy("nisha.txt", "28.txt");

        // Display file2 contents
        Console.WriteLine(File.ReadAllText("28.txt"));

        string Oldfilepath = @"C:\Users\nisha.hiremani\source\repos\day12\copy_file\copy_file\bin\Debug\nisha.txt";
        string NewFilePath = @"C:\Users\nisha.hiremani\source\repos\day12\copy_file\copy_file\28.txt";
        StreamReader reader = new StreamReader(Oldfilepath);
        string fileContent = reader.ReadToEnd();

        StreamWriter writer = new StreamWriter(NewFilePath);
        writer.Write(fileContent);
    }
}
