using System;
namespace Fellowship
{
    class CubeRoot
    {
        static int Main()
        {
            int number, root;
            Console.Write("Enter the value of number ");
            number = Convert.ToInt32(Console.ReadLine());

            root = Math.Ceiling(Math.Pow(number, (int)1 / 3));
            Console.WriteLine("Cube Root is : " + root);

            return 0;
        }
    }
}