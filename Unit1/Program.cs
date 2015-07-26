using System;

namespace Methods
{


	class Program
	{
		public static void Main (string[] args)
		{
			//first assignment
			var clock = new Stopwatch();
			clock.Start ();
			clock.Stop ();
			Console.WriteLine ("Duration" + clock.Span ());

			//second assignment
			var post = new Post();
			post.title = "The amazing Rachel";
			post.UpVote();
			post.UpVote();
			post.DownVote();
			post.DisplayVotes();
		}
	}
}
