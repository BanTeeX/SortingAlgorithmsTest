using SortingAlgorithmsTest.Sorts.Algorithms;
using SortingAlgorithmsTest.TableGenerators.GeneratorMethods;
using SortingAlgorithmsTest.TestTools.DataStructures;

namespace SortingAlgorithmsTest.TestTools.Builders
{
	internal class SortsTestWithGivenTableSizes : ISortsTestBuilder<List<SortTestCase>>
	{
		private readonly IEnumerable<ISortingAlgorithm> _algorithms;
		private readonly IEnumerable<ITableGenerator> _tableGenerators;
		private readonly IEnumerable<int> _tableSizes;

		public SortsTestWithGivenTableSizes(
			IEnumerable<ISortingAlgorithm> algorithms,
			IEnumerable<ITableGenerator> tableGenerators,
			IEnumerable<int> tableSizes)
		{
			_algorithms = algorithms;
			_tableGenerators = tableGenerators;
			_tableSizes = tableSizes;
		}

		public List<SortTestCase> Build()
		{
			var tests = new List<SortTestCase>();

			foreach (var generator in _tableGenerators)
			{
				foreach (var size in _tableSizes)
				{
					var tab = generator.Generate(size);
					foreach (var algorithm in _algorithms)
					{
						tests.Add(new SortTestCase(algorithm, (int[])tab.Clone(), generator));
					}
				}
			}

			return tests;
		}
	}
}
