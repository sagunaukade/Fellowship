using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
	public class DefaultConstructor
	{
		int num;
		A() //default
		
		{
			num = 100;
		}
		public static void show()
		
		{
			Console.WriteLine(num);
		}
		public static void Main()
		
		{
			A r = new A();//constructor
            r.show(); //method object

        }
		
		
	}
}
