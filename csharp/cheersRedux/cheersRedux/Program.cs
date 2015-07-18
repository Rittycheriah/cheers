using System;
using System.Text;
using System.Linq;
using System.Windows;
using System.IO;

namespace cheersRedux
{
	class cheersClass 
	{
		public static void Main(string[] args) 
		{ 
			Console.WriteLine ("What is your name?");
			var UserName = Console.ReadLine ();

			foreach (char i in UserName)
		   	{
				if ("aeiou".Contains(i)) 
				{
					Console.WriteLine("Give me an...{0}", i);
				} 
				else 
				{
					Console.WriteLine("Give me a...{0}", i);
				}
			}

			Console.Write(UserName);
			Console.Write (" is FABULOUS!");
				
		}
	}
}
