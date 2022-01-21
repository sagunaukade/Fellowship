using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class Addition2
    {
        public static void Main(String[] args)
        {
            int a, b, r;
            Console.WriteLine("Enter two nums");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            r = a + b;
            Console.WriteLine("Addition of two nums" + r);
        }
    }
}
