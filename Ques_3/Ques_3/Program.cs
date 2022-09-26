using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    class Student
    {
       
        static void Main()
        {
            //Creating a Generic List 
            List<string> Student = new List<string> {
            
             "Sravan",
            "deepu",
             "manoja",
            "Sathwik",
             "Saran"
        };
           
            Console.WriteLine("Accessing Generic List Elemenst");
            foreach (var item in Student)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}