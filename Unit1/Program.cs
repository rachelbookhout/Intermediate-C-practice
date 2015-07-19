using System;

namespace Methods
{


	class Program
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			var clock = new Stopwatch();
			var start = clock.Start ();
			Console.WriteLine (start);
			var stop = clock.Stop ();
			var span = clock.Span (start, stop);
			Console.WriteLine(span.ToString());



			//design class StopWatch
			// has two methods - start and stop
			// run start method, then stop method, then ask the stopwatch for the duration. Needs to return as a TimeSpan. Display on console
			//must be able to start and stop constantly
			//raises an exception if you try to start a stopwatch twice (InValidOperationException

		}
	}
}
