//encapsulation
using System;

public class Calci
{
    private double result;
    public static add(double n1,double n2)
    {
        result=n1+n2;
        return result;
    }
}

//Data hiding
//private and public

//inheritance
public class Person{
    public string name;
    public int age;
}
public class Student:Person //the colon(:) indicates inheritance
{
    public int rollnumber;
    public string stream;
}
public class Employee:Person //the colon(:) indicates inheritance
{
    public int EmployeeID;
    public doulbe salary;
    
}
 class RectangleTester {
   
      static void Main(string[] args) {
         Employee Rect = new Employee();

         Rect.EmployeeID(5);
         Rect.salary(7000);

         // Print the area of the object.
         Console.WriteLine("Total area: {0}",  Rect.getArea());
         Console.ReadKey();
      }
//
//1. Write a C# Sharp program that takes three letters as input and display them in reverse order. Go to the editor
// Test Data
// Enter letter: b
// Enter letter: a
// Enter letter: t
// Expected Output :
// t a b
//
// 2. Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number. Go to the editor
// Test Data
// Enter a number: 6
// Enter the desired width: 6
// Expected Output :

// 666666                                                      
// 66666                                                           
// 6666                                                                  
// 666                                                        
// 66                                                                  
// 6 

// 3. Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected
