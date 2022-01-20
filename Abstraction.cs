using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Abstraction
    {
        abstract class Shape {
 
    // abstract method
    public abstract int area();
}
 
// square class inheriting
// the Shape class
class Square : Shape {
 
    // private data member
    private int side;
 
    // method of  square class
    public Square(int x = 0)
    {
        side = x;
    }
     
    // overriding of the abstract method of Shape
    // class using the override keyword
    public override int area()
    {
        Console.Write("Area of Square: ");
        return (side * side);
    }
}
 
// Driver Class
      class GFG {
     
    // Main Method
    static void Main(string[] args)
    {
         
        // creating reference of Shape class
        // which refer to Square class instance
        Shape sh = new Square(4);
         
        // calling the method
        double result = sh.area();
         
        Console.Write("{0}", result);
  
    }
}
}
    }

