using SortingAlgorithmsTest.Sorts;
using SortingAlgorithmsTest.Sorts.Algorithms;
using SortingAlgorithmsTest.TableGenerators;
using SortingAlgorithmsTest.TableGenerators.GeneratorMethods;
using SortingAlgorithmsTest.Tests.Builders;
using SortingAlgorithmsTest.Tests.Savers;
using SortingAlgorithmsTest.Tests.Testers;

namespace SortingAlgorithmsTest
{
	internal class Part3
	{
		private static readonly ISortingAlgorithm[] _algorithms = new[] { SortsInstances.RecursiveQuickSort, SortsInstances.IterativeQuickSort };
		private static readonly ITableGenerator[] _generators = new[] { TableGeneratorsInstances.Random };
		private static readonly ISortingAlgorithm[] _algorithms2 = new[]
		{
			/*SortsInstances.IterativeQuickSort,
			new IterativeQuickSort((tab, left, right) => tab[right], "Pivot right"),
			new IterativeQuickSort((tab, left, right) =>
			{
				var random = new Random();
				return tab[random.Next(left, right + 1)];
			}, "Pivot random"),*/
			SortsInstances.RecursiveQuickSort
			/*new RecursiveQuickSort((tab, left, right) => tab[right], "Pivot right"),
			new RecursiveQuickSort((tab, left, right) =>
			{
				var random = new Random();
				return tab[random.Next(left, right + 1)];
			}, "Pivot random")*/
		};
		private static readonly ITableGenerator[] _generators2 = new[] { TableGeneratorsInstances.AShaped };
		private static readonly int[] _tableSizes = new int[1];
		private static readonly int _minSize = 24220;
		private static readonly int _maxSize = 24220;
		private static readonly string _filePath = "resultsPart3.txt";

		public static void Start()
		{
			var j = _minSize;
			for (var i = 0; i < _tableSizes.Length; i++)
			{
				_tableSizes[i] = j;
				if (_tableSizes.Length > 1)
				{
					j += (_maxSize - _minSize) / (_tableSizes.Length - 1);
				}
			}
			var tester = new SortsTimeTester();
			var builder = new SortsTestWithGivenTableSizes(_algorithms, _generators, _tableSizes);
			var builder2 = new SortsTestWithGivenTableSizes(_algorithms2, _generators2, _tableSizes);
			var saver = new TxtFileSaver(_filePath);
			var progress = new Progress<ProgressReport>();
			progress.ProgressChanged += UpdateProgress;

			var tests = builder2.Build();
			//tests.AddRange(builder2.Build());

			var result = tester.RunTests(tests, progress);

			//await saver.SaveAsync(result);
		}

		private static void UpdateProgress(object? sender, ProgressReport report)
		{
			var tmp = Console.CursorTop;
			Console.CursorTop = 1;
			Console.Write($"\rPart 3 tests in progress: {report.done}/{report.todo}");
			Console.CursorTop = tmp;
		}
	}
}
