using System;
namespace Fellowship
{
    class AreaOfCircle

    {
        static void main(String[] args)

        {
            Console.WriteLine("Enter Radius");
            Double Radious = Convert.ToDouble(Console.ReadLine);
            double Area = Math.PI * Radious * Radious;
            Console.WriteLine("Area of Circle" + Area);
            Console.ReadLine();
        }
    }
}