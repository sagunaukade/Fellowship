using System.Data;
using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string name;
            Console.WriteLine("Enter name");
            name = Console.Readline();
            Console.Write("my name is" + name);
        }
    }
}
