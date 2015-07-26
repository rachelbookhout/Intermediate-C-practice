using System;

namespace Methods
{
	public class Post
	{
		
		//has properties for title, description, and dateTime it was created
		//methods - upvote and downvote
		// need to see current vote value

		public string title { get; set;}
		public string description {get;set;}
		private int upVoteCount = 0;
		private int downVoteCount = 0;
		private DateTime _created;

		public DateTime Created {
			get { return _created; }
			set{ _created = DateTime.Now;}
		}

		public void UpVote()
		{
			upVoteCount += 1;
		}

		public void DownVote()
		{
			downVoteCount += 1;
		}

		public void DisplayVotes()
		{
			Console.WriteLine ("Post titled" + this.title + "has an UpVote count of " + upVoteCount + "and a DownVote:" + downVoteCount);
		}


				//should not give the ability to set the Vote property from the outside,
					

	}
}

