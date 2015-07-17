using System;
using System.Text;
using System.Windows;
using System.IO;

namespace cheersRedux
{
	class cheersClass 
	{
		public static void Main(string[] args) 
		{
			string line; 
			Console.WriteLine ("What is your name?");
			var UserName = Console.ReadLine ();

			char[] nameArray = new char[UserName.Length];

		   	for (int i = 0; i < nameArray.length; i++) 
		   	{
				if (i == "a" || "e" || "o" || "i" || "u") 
				{
					Console.WriteLine("Give me an...{0}", i);
				} 
				else 
				{
					Console.WriteLine("Give me a...{0}", i);
				}
			}
		}
	}
}
