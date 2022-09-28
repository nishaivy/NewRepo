using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         eligible:  
         Console.WriteLine("You are eligible to vote!");
         Console.WriteLine("Enter your age:\n");  
      int age = Convert.ToInt32(Console.ReadLine());  
      if (age > 18){  
              goto eligible;  
      }  
      else  
      {  
              Console.WriteLine("You are not eligible to vote!");   
      }  
    
    int i = 2; 
         while (i < 18){
             Console.WriteLine(i);
             i++;
             if (i>9){
                 break;
             }
             else if (i == 3) {
                 i++;
                 continue;
               }
         }
      }
   }
} 

//string name = "INDIA";
    //       int i=0;
    //       while(i<name.length){
    //           if(name.startwith('A'))
    //           break;
    //           Console.Writeline(name.substring(i,1));
    //           ++i;
    //       }
    //      Console.Writeline("name starts with vowel") ;
    //   }