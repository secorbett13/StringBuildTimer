namespace StringBuildTimer
{
	using System;
	using System.Diagnostics;

	public static class StopWatchExtensions
	{
		public static long RunTests(
			this Stopwatch stopwatch,
			int numIterations,
			Action testFunction)
		{
			stopwatch.Restart();

			for (var i = 0; i < numIterations; ++i)
			{
				testFunction();
			}

			return stopwatch.ElapsedMilliseconds;
		}
	}
}
