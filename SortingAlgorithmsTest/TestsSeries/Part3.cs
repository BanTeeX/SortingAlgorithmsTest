using SortingAlgorithmsTest.Loggers;
using SortingAlgorithmsTest.Sorts;
using SortingAlgorithmsTest.Sorts.Algorithms;
using SortingAlgorithmsTest.TableGenerators;
using SortingAlgorithmsTest.TableGenerators.GeneratorMethods;
using SortingAlgorithmsTest.TestTools.Builders;
using SortingAlgorithmsTest.TestTools.DataStructures;
using SortingAlgorithmsTest.TestTools.Savers;
using SortingAlgorithmsTest.TestTools.Testers;

namespace SortingAlgorithmsTest.TestsSeries
{
	internal class Part3
	{
		private static readonly ISortingAlgorithm[] _algorithms = new[] { SortsInstances.RecursiveQuickSort, SortsInstances.IterativeQuickSort };
		private static readonly ITableGenerator[] _generators = new[] { TableGeneratorsInstances.Random };
		private static readonly ISortingAlgorithm[] _algorithms2 = new[]
		{
			SortsInstances.IterativeQuickSort,
			new IterativeQuickSort((tab, left, right) => tab[right], "Pivot right"),
			new IterativeQuickSort((tab, left, right) =>
			{
				var random = new Random();
				return tab[random.Next(left, right + 1)];
			}, "Pivot random")
		};
		private static readonly ITableGenerator[] _generators2 = new[] { TableGeneratorsInstances.AShaped };
		private static readonly int[] _tableSizes = new int[31];
		private static readonly int _minSize = 50000;
		private static readonly int _maxSize = 200000;
		private static readonly string _filePath = "resultsPart3.txt";

		private readonly ILogger _logger;
		private readonly SortsTesterBase<SortTestCase, SortTestResult> _tester;
		private readonly List<SortTestCase> _tests;
		private readonly ISortTestResultSaver<IEnumerable<SortTestResult>> _saver;
		private readonly Progress<ProgressReport> _progress;

		public Part3(ILogger logger)
		{
			_logger = logger;

			_logger.Log(this, "Part 3 tests status: Initializing");

			var j = _minSize;
			for (var i = 0; i < _tableSizes.Length; i++)
			{
				_tableSizes[i] = j;
				if (_tableSizes.Length > 1)
				{
					j += (_maxSize - _minSize) / (_tableSizes.Length - 1);
				}
			}
			_tester = new SortsTimeTester();
			var builder = new SortsTestWithGivenTableSizes(_algorithms, _generators, _tableSizes);
			var builder2 = new SortsTestWithGivenTableSizes(_algorithms2, _generators2, _tableSizes);
			_tests = builder2.Build();
			_tests.AddRange(builder2.Build());
			_saver = new TxtFileSaver(_filePath);
			_progress = new Progress<ProgressReport>();
			_progress.ProgressChanged += (sender, progress) => UpdateProgress(progress);

			_logger.Log(this, "Part 3 tests status: Initialized");
		}
		public void Start()
		{
			_logger.Log(this, "Part 3 tests status: Starting");

			var result = _tester.RunTests(_tests, _progress);

			_logger.Log(this, "Part 3 tests status: Saving results");

			_saver.Save(result);

			_logger.Log(this, "Part 3 tests status: Completed");
		}

		private void UpdateProgress(ProgressReport report)
		{
			_logger.Log(this, $"Part 3 tests status: In progress {report.done}/{report.todo}");
		}
	}
}
