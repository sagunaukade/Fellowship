using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
	public class Switch
	{
		public static void Main(string[] args)
		
		{
			int ch;
			Console.WriteLine("Enter ur choice");
			ch = Convert.ToInt32(Console.ReadLine());
			switch(ch)
			
			{
				case 1:
					Console.WriteLine("Saguna");
					break;
				case 2:
					Console.WriteLine("Ukade");
					break;
				default:
					Console.WriteLine("Invalid user input");
                    break;

            }
		}
	}
}
