using System;
using System.Text;
using System.Windows;
using System.IO;

namespace cheersRedux
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}
	}

	class cheersClass 
	{
		public static void Main() 
		{
			string line; 
			Console.WriteLine ("What is your name?");
			var UserName = Console.ReadLine ();

			char[] nameArray = new char[UserName.Length];

			using (StringReader intoNameArray = new StringReader (UserName)) 
			{
				for (int i = 0; i < UserName.Length; i++) 
				{
					if (UserName[i] == 'a' || 'e' || 'o' || 'i '||'u') {
						Console.WriteLine('Give me an...' UserName[i])
					} else {
						Console.WriteLine('Give me a...' UserName[i])
					};
				}
			}
		}

	}
}
