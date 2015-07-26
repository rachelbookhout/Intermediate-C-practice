using System;

namespace Methods
{


	class Program
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			var clock = new Stopwatch();
			clock.Start ();
			clock.Stop ();
			Console.WriteLine ("Duration" + clock.Span ());

		}
	}
}
