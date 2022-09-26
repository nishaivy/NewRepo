using System;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

class filexercise3
{
    public static void Main()
    {
        string fileName = @"mytest.txt";
        try
        {

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write("Append some text to an existing file  :\n\n");

            using (StreamWriter fileStr = File.CreateText(fileName))
            {
                fileStr.WriteLine(" Hello and Welcome");
                fileStr.WriteLine(" It is the first content");
                fileStr.WriteLine(" of the text file mytest.txt");
            }
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.WriteLine(" Before appending : ");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"mytest.txt", true))
            {
                file.WriteLine(" This is the line appended line.");
            }
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.WriteLine(" after appending the text : ");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }

        }
        catch (Exception MyExcep)
        {
            Console.WriteLine(MyExcep.ToString());
        }
    }
}

//Output:
//Append some text to an existing file  :

// Before appending :
// Hello and Welcome
// It is the first content
// of the text file mytest.txt

// after appending the text :
// Hello and Welcome
// It is the first content
// of the text file mytest.txt
// This is the line appended line.
