using System;
using System.Collections.Generic;

namespace ListCollectionDemo
{
    public class Program
    {
        public static void Main()
        {
            // Create Employee Objects
            Employee emp1 = new Employee() { ID = 101, Name = "Pranaya" };
            Employee emp2 = new Employee() { ID = 101, Name = "Nisha" };
            Employee emp3 = new Employee() { ID = 102, Name = "Priyanka"};
            Employee emp4 = new Employee() { ID = 103, Name = "Anurag"};
            Employee emp5 = new Employee() { ID = 104, Name = "Sambit"};

            // Create a List of Employees
            List<Employee> listEmployees = new List<Employee>();

            //Adding Employees to the collection using Add Method
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            listEmployees.Add(emp4);
            listEmployees.Add(emp5);


            Console.WriteLine("\nRetrieving All Employees using For Loop");
            for (int i = 0; i < listEmployees.Count; i++)
            {
                Employee employee = listEmployees[i];
                Console.WriteLine($"Name = {employee.Name}");
            }
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
    }
}