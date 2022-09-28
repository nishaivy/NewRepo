using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
          string state = "tired";
           switch (state){
             case "normal":
                Console.WriteLine("continue the work");
                goto default;		
             case "hungry":
                Console.WriteLine("eat some stuff");
                goto case "normal";	
             case "illness":
               Console.WriteLine("go to doctor");
               break;
              case "tired":
                Console.WriteLine("take some rest");
                goto case "normal";
             default:
             Console.WriteLine("go to sleep");
             break;
               
           }
      }
   }
} 