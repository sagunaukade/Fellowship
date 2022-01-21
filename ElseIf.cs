using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
	public class ElseIf
	{
		public static void Main(String[] args)
		
		{
			int marks = 88;
			if(marks>=89 && marks>=87)
			
			{
				Console.WriteLine("Topper...");
			}
			else if(marks>=67 && marks>=64)
			
			{
				Console.WriteLine("Passed...");
			}
			else
			
			{
                Console.WriteLine("Failed...");
            }
		}
	}
}
