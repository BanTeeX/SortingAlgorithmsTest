using SortingAlgorithmsTest.Sorts;
using SortingAlgorithmsTest.Sorts.Algorithms;
using SortingAlgorithmsTest.TableGenerators;
using SortingAlgorithmsTest.TableGenerator.GeneratorMethods;
using SortingAlgorithmsTest.Tests.Testers;
using SortingAlgorithmsTest.Tests.Builders;
using SortingAlgorithmsTest.Tests;
using SortingAlgorithmsTest.Tests.Savers;
using SortingAlgorithmsTest.Tests.DataStructures;

namespace SortingAlgorithmsTest
{
	internal static class Part1And2
	{
		private static readonly ISortingAlgorithm[] _algorithms = new[] { SortsInstances.SelectionSort, SortsInstances.InsertionSort, SortsInstances.CocktailSort, SortsInstances.HeapSort };
		private static readonly ITableGenerator[] _generators = new[] { TableGeneratorsInstances.SortedAscending, TableGeneratorsInstances.SortedDescending, TableGeneratorsInstances.Constant, TableGeneratorsInstances.Random, TableGeneratorsInstances.VShaped };
		private static readonly int[] _tableSizes = new int[30];
		private static readonly string _filePath = "results.txt";

		public static async Task Start()
		{
			for (int i = 0, j = 50000; i < _tableSizes.Length; i++, j += 5000)
			{
				_tableSizes[i] = j;
			}
			var tester = new SortsTimeTester();
			var builder = new SortsTestWithGivenTableSizes(_algorithms, _generators, _tableSizes);
			var saver = new TxtFileSaver(_filePath);
			var test = new SortsTestRunner<SortTestCase, SortTestResult>(tester, builder, saver);
			var progress = new Progress<ProgressReport>();
			progress.ProgressChanged += UpdateProgress;
			await test.Run(progress);
		}

		private static void UpdateProgress(object? sender, ProgressReport report)
		{
			Console.Write($"\rTest in progress: {report.done}/{report.todo}");
		}
	}
}
