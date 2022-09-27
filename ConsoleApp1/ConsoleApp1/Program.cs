using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //public static string filename = "C:\\Users\\nisha.hiremani\\source\\repos\\day12\\ConsoleApp1\\ConsoleApp1\\mytest.dat";
        // static void BinaryFileCreate()
        // {
        //     BinaryWriter B = new BinaryWriter(File.Open(filename, FileMode.Create));
        //     B.Write("Hello");
        //     // B.Close();

        // }
        // static void BinaryFileRead()
        // {
        //     //try
        //     //{
        //     BinaryReader r = new BinaryReader(File.Open(filename, FileMode.Open));
        //     Console.WriteLine(r.ReadString());
        //     //}

        //     // catch (Exception ex)
        //     //{
        //     //    //Console.WriteLine(ex.Message);
        //     //}

        // }
        string s= "hello everyone";
       // StringBuilder sb= new StringBuilder();
        StringWriter a= new StringWriter();
        a.WriteLine(s);
        a.Close();

            StringReader stringReader = new StringReader(a.ToString());
        Console.WriteLine(stringReader.ReadLine());
        //static void Main(string[] args)
        //{
        // //  BinaryFileCreate();
        //    //BinaryFileRead();
           
        //}
    }
}
