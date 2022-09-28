using System;

namespace Inheritance {
   
   class Shape {
      
      public void setWidth(int w) {
         width = w;
      }
      
      public void setHeight(int h) {
         height = h;
      }
      private int width;
      private int height;
   }
   class Rectangle: Shape {
      
      public int getArea() { 
         return (width * height); 
      }
   }
   
   class RectangleTester {
   
      static void Main(string[] args) {
         Rectangle Rect = new Rectangle();

         Rect.setWidth(5);
         Rect.setHeight(7);.
         Console.WriteLine("Area: {0}",Rect.getArea());
         Console.ReadKey();
      }
   }
}