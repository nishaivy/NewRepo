using System;

namespace MyApplication
{
  class Car
  {
    static void Engine(string fname, int daysused)
    {
      Console.WriteLine(fname + " is " + daysused+" days used");
    }
    static void Main(string[] args)
    {
      Engine("Volvo", 5);
       AddPetrol(100);
    }
    static void AddPetrol(int gallons){
    Console.WriteLine("Added petrol of {0} rupees",gallons);
    }
  }
}