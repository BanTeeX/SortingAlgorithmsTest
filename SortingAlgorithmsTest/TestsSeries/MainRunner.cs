using SortingAlgorithmsTest.Loggers;

namespace SortingAlgorithmsTest.TestsSeries
{
	internal static class MainRunner
	{
		public static void Run()
		{
			var logger = new ConsoleLogger();

			Console.WriteLine("Sorting algorithms tests");

			Parallel.Invoke(
				new Part1And2(logger).Start,
				new Part3(logger).Start
			);

			Console.WriteLine("Tests completed");
		}
	}
}
