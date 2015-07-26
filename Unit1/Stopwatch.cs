using System;

namespace Methods
{


	//must be able to start and stop constantly
	//raises an exception if you try to start a stopwatch twice (InValidOperationException

	public class Stopwatch
	{
		// intialize it with bool false
		private bool _started = false;
		private DateTime _startTime;
		private DateTime _endTime;

			public void  Start()
			{
				_startTime = DateTime.Now;
				//do an if/else method -> throws exception if already true
				if (_started)
				{
				throw new InvalidOperationException ("Stopwatch is already running");
					
				}
			_startTime = DateTime.Now;
			_started = true;

			}

			public void  Stop()
			{
					
			if ( !_started)
			{
				throw new InvalidOperationException ("Stopwatch hasn't been started");
			}
			_endTime = DateTime.Now;
			_started = false;
			}

			public TimeSpan Span()
			{
			return _endTime - _startTime;
			}

			}
		}



