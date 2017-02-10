using System;
using System.Text;

namespace StringBuildTimer
{
	using System.Diagnostics;

	class Program
	{
		static void Main(string[] args)
		{
			var numIterations = 10000;

			var formatString = string.Empty;

			for (var i = 0; i < 1000; ++i)
			{
				formatString += "{" + i + "}";
			}

			var testString1 = (int)new Random(1234).NextDouble();
			var testString2 = (int)new Random(3456).NextDouble();
			var testString3 = (int)new Random(4567).NextDouble();

			var report =
				"Test,Time\n" +
				"Concatenation 1," + RunTests(numIterations, () => Concatenation(testString1)) + "\n" +
				"String.Format 1," + RunTests(numIterations, () => StringFormat(formatString, testString1)) + "\n" +
				"String Builder 1," + RunTests(numIterations, () => StringBuilder(testString1));

			Console.WriteLine(report);

			report =
				"Test,Time\n" +
				"Concatenation 2," + RunTests(numIterations, () => Concatenation(testString2)) + "\n" +
				"String.Format 2," + RunTests(numIterations, () => StringFormat(formatString, testString2)) + "\n" +
				"String Builder 2," + RunTests(numIterations, () => StringBuilder(testString2));

			Console.WriteLine(report);

			report =
				"Test,Time\n" +
				"Concatenation 3," + RunTests(numIterations, () => Concatenation(testString3)) + "\n" +
				"String.Format 3," + RunTests(numIterations, () => StringFormat(formatString, testString3)) + "\n" +
				"String Builder 3," + RunTests(numIterations, () => StringBuilder(testString3));

			Console.WriteLine(report);

			Console.ReadLine();
		}

		private static long RunTests(int numIterations, Action testFunction)
		{
			var stopwatch = new Stopwatch();

			stopwatch.Start();

			for (var i = 0; i < numIterations; ++i)
			{
				testFunction();
			}

			stopwatch.Stop();
			return stopwatch.ElapsedMilliseconds;
		}

		private static string StringFormat(string formatString, int toConcat)
		{
			var s = toConcat;
			return string.Format(
				formatString,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s,
				s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s, s
			);
		}

		private static string Concatenation(int toConcat)
		{
			var s = toConcat;
			return
				s.ToString() + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s +
				s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s;
		}

		private static string StringBuilder(int toConcat)
		{
			var s = toConcat;
			var builder = new StringBuilder();
			for (int i = 0; i < 1000; ++i)
			{
				builder.Append(s);
			}

			return builder.ToString();
		}
	}
}
