using System;

namespace Methods
{


	//must be able to start and stop constantly
	//raises an exception if you try to start a stopwatch twice (InValidOperationException

	public class Stopwatch
	{
		// intialize it with bool false
		private bool started = false;
		public bool Started 
		{
			get 
			{ 
				return started;
			}
			set 
			{ 
				started = value;
			}
			}

			public DateTime Start()
			{
				DateTime start = DateTime.Now;
				//do an if/else method -> throws exception if already true
				if (started == false) 
				{
					bool Started = true;
					return start;
				}
				else 
				{
					throw new InvalidOperationException ();
				}
			}
			
			public DateTime Stop()
				{
					DateTime stop = DateTime.Now;
					bool Started = false;
					return stop;
				}

			public TimeSpan Span(DateTime start, DateTime stop)
				{
					TimeSpan span = start - stop;
					return span;
				}

			}
		}



