using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApplication
{
   class Number
    {
        double value;

        public void setvalue(double v)
        {
            value = v;
        }
        public void getvalue()
        {
            Console.WriteLine("value is " + value);
        }
        public static Number operator +(Number n1, Number n2)
        {
            Number result = new Number();
            result.value = (n1.value) + (n2.value);
            return result;
        }

    }

class Program
  {
    static void Main(string[] args)
    {
      Number result1= new Number();  
      result1.setvalue(10);
      result1=result1+result1;
      result1.getvalue();
    }
  }
}