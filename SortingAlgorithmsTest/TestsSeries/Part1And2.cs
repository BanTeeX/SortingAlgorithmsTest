using SortingAlgorithmsTest.Sorts;
using SortingAlgorithmsTest.Sorts.Algorithms;
using SortingAlgorithmsTest.TableGenerators;
using SortingAlgorithmsTest.TableGenerators.GeneratorMethods;
using SortingAlgorithmsTest.Loggers;
using SortingAlgorithmsTest.TestTools.DataStructures;
using SortingAlgorithmsTest.TestTools.Savers;
using SortingAlgorithmsTest.TestTools.Testers;
using SortingAlgorithmsTest.TestTools.Builders;

namespace SortingAlgorithmsTest.TestsSeries
{
	internal class Part1And2
	{
		private static readonly ISortingAlgorithm[] _algorithms = new[] { SortsInstances.SelectionSort, SortsInstances.InsertionSort, SortsInstances.CocktailSort, SortsInstances.HeapSort };
		private static readonly ITableGenerator[] _generators = new[] { TableGeneratorsInstances.SortedAscending, TableGeneratorsInstances.SortedDescending, TableGeneratorsInstances.Constant, TableGeneratorsInstances.Random, TableGeneratorsInstances.VShaped };
		private static readonly int[] _tableSizes = new int[31];
		private static readonly int _minSize = 50000;
		private static readonly int _maxSize = 200000;
		private static readonly string _filePath = "resultsPart1And2.txt";

		private readonly ILogger _logger;
		private readonly SortsTesterBase<SortTestCase, SortTestResult> _tester;
		private readonly List<SortTestCase> _tests;
		private readonly ISortTestResultSaver<IEnumerable<SortTestResult>> _saver;
		private readonly Progress<ProgressReport> _progress;

		public Part1And2(ILogger logger)
		{
			_logger = logger;

			_logger.Log(this, "Part 1 and 2 tests status: Initializing");

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
			_tests = new SortsTestWithGivenTableSizes(_algorithms, _generators, _tableSizes).Build();
			_saver = new TxtFileSaver(_filePath);
			_progress = new Progress<ProgressReport>();
			_progress.ProgressChanged += (sender, progress) => UpdateProgress(progress);

			_logger.Log(this, "Part 1 and 2 tests status: Initialized");
		}

		public void Start()
		{
			_logger.Log(this, "Part 1 and 2 tests status: Starting");

			var result = _tester.RunTests(_tests, _progress);

			_logger.Log(this, "Part 1 and 2 tests status: Saving results");

			_saver.Save(result);

			_logger.Log(this, "Part 1 and 2 tests status: Completed");
		}

		private void UpdateProgress(ProgressReport report)
		{
			_logger.Log(this, $"Part 1 and 2 tests status: In progress {report.done}/{report.todo}");
		}
	}
}
