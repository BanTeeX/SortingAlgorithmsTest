using SortingAlgorithmsTest.Sorts;
using SortingAlgorithmsTest.Sorts.Algorithms;
using SortingAlgorithmsTest.TableGenerators;
using SortingAlgorithmsTest.Tests.Testers;
using SortingAlgorithmsTest.Tests.Builders;
using SortingAlgorithmsTest.Tests.Savers;
using SortingAlgorithmsTest.TableGenerators.GeneratorMethods;

namespace SortingAlgorithmsTest
{
	internal static class Part1And2
	{
		private static readonly ISortingAlgorithm[] _algorithms = new[] { SortsInstances.SelectionSort, SortsInstances.InsertionSort, SortsInstances.CocktailSort, SortsInstances.HeapSort };
		private static readonly ITableGenerator[] _generators = new[] { TableGeneratorsInstances.SortedAscending, TableGeneratorsInstances.SortedDescending, TableGeneratorsInstances.Constant, TableGeneratorsInstances.Random, TableGeneratorsInstances.VShaped };
		private static readonly int[] _tableSizes = new int[31];
		private static readonly int _minSize = 50000;
		private static readonly int _maxSize = 200000;
		private static readonly string _filePath = "resultsPart1And2.txt";

		public static async Task Start()
		{
			var j = _minSize;
			for (var i = 0; i < _tableSizes.Length; i++)
			{
				_tableSizes[i] = j;
				j += (_maxSize - _minSize) / (_tableSizes.Length - 1);
			}
			var tester = new SortsTimeTester();
			var builder = new SortsTestWithGivenTableSizes(_algorithms, _generators, _tableSizes);
			var saver = new TxtFileSaver(_filePath);
			var progress = new Progress<ProgressReport>();
			progress.ProgressChanged += UpdateProgress;

			var result = await tester.RunTestsAsync(builder.Build(), progress);
			await saver.SaveAsync(result);
		}

		private static void UpdateProgress(object? sender, ProgressReport report)
		{
			Console.CursorTop = 0;
			Console.Write($"\rPart 1 and 2 tests in progress: {report.done}/{report.todo}");
		}
	}
}
