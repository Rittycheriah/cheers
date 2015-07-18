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

			Console.WriteLine ("What is your birthday?");
			var userb = Console.ReadLine ();
			DateTime userBday = Convert.ToDateTime(userb);
			DateTime current = DateTime.Now;

			TimeSpan finalCalc;

			if (userBday > current) {
				finalCalc = userBday - current;
			} else {
				finalCalc = current - userBday; 
			}

			int differenceInDays = finalCalc.Days;

			foreach (char i in UserName)
		   	{
				if ("halfnorsemix".Contains(i)) 
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
			Console.WriteLine ("  ");
			Console.Write ("Your birthday is {0} days away", differenceInDays);	
		}
	}
}
