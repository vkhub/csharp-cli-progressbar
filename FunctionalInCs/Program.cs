using System;
using System.Collections.Immutable;
using System.Threading;
using static System.Console;

namespace FunctionalInCs
{
	class Program
	{
		public struct ImmTest
		{
			public string FirstName;
			public string LastName;
			public string Email;
		}

		public static int square(int x) => x * x;

		static void Main(string[] args)
		{
			var y = square(12);
			var test = new ImmTest { FirstName = "Volker", LastName = "Knöss", Email = "Volker@gmx.ch" };
			var test2 = test;
			test2.Email = "volker@knoess.com";
			WriteLine(test.Email);
			WriteLine(test2.Email);


			var list = ImmutableList.Create<string>("Apfel", "Birne");
			var newList = list.Add("Orange");

			list.ForEach(WriteLine);
			newList.ForEach(WriteLine);

			for (int f = 0; f < 20; f++)
			{
				Console.Write("Performing some task... ");
				using (var progress = new ProgressBar())
				{
					for (int i = 0; i <= 300; i++)
					{
						progress.Report(i, 300);
						Thread.Sleep(20);
					}
				}
				WriteLine(" => Done.");
			}
			Console.ReadLine();
		}
	}
}
