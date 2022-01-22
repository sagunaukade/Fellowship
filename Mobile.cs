using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
	public class Mobile
	{
		int price;
		string storage;
		string color;
		public void Calling()
		
		{
			Console.WriteLine("calling...");
		}
		public void Chatting()
		
		{
			Console.WriteLine("Chatting");
		}
		public void Music()
		
		{
			Console.WriteLine("Music...");
		}
		public static void Main()
		
		{
			Mobile m1 = new Mobile();
			m1.price = 100000;
			m1.storage = "8 gb";
			m1.color = "black";
			Console.WriteLine("m.price");
			Console.WriteLine("m.storage");
			Console.WriteLine("m.color");
			
			m1.Chatting();
			m1.Calling();
			m1.Music();
		}
	}
}
