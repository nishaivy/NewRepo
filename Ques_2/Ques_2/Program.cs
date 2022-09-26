//Write a program in C# Sharp to create a list with StudentID and StudentMarks as key value pair;
//use any suitable collection. Display the list on the screen.
//The output should have list of IDs, Names and Pass Status of Students like [12, Rahul Y], [14, Kiran, N

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{

    int id;
    string Status;
    string name;

    // Get the to string method that returns 
    // id , name and Status
    public override string ToString()
    {
        return id + " " + name + " " + Status;
    }

    // Driver code
    static void Main(string[] args)
    {
        // Declare a list variable 
        List<Student> student = new List<Student>()
    {
        new Student{ id = 101, name = "Sravan", Status ="Y"},
        new Student{ id = 102, name = "deepu", Status = "N"},
        new Student{ id = 103, name = "manoja", Status = "Y"},
        new Student{ id = 104, name = "Sathwik", Status = "N" },
        new Student{ id = 105, name = "Saran", Status = "N" }
   
     };
       
        IEnumerable<Student> Query = student.Where(s => s.Status[0] == 'Y');
        // Display employee details
        Console.WriteLine("ID  Name  Status");
        foreach (Student e in Query)
        {
            Console.WriteLine(e.ToString());
        }
    }
}

//Output:
//ID Name  Status
//101 Sravan Y
//103 manoja Y