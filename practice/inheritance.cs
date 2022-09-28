using System;
namespace Inheritance {
class Person {
   
  
    public string name;
    public int age;
    public int EmployeeID;
    public int salary;
   
    public void EmployeeDetail(string name, int age,int salary,int EmployeeID)
    {
        this.name = name;
        this.age = age;
        this.salary=salary;
        this.EmployeeID=EmployeeID;
        Console.WriteLine("Name: " + name); 
        Console.WriteLine("My age is " +age);
        Console.WriteLine("EmployeeID: "+EmployeeID);
        Console.WriteLine("salary: "+salary);
    }
}
  

class Employee : Person {
    public Employee()
    {
      
        Console.WriteLine("Employee Details: ");
    }
}
   

class Details {
  
    
    static void Main(string[] args)
    {
        Employee e = new Employee();
        e.EmployeeDetail("Nisha",22,12000,34);
    }
}
}