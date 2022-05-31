using SortingAlgorithmsTest.Sorts.Algorithms;
using SortingAlgorithmsTest.TableGenerator.GeneratorMethods;
using SortingAlgorithmsTest.Tests.DataStructures;

namespace SortingAlgorithmsTest.Tests.Builders
{
	internal class SortsTestWithGivenTableSizes : ISortsTestBuilder<List<SortTestCase>>
	{
		public IEnumerable<ISortingAlgorithm> Algorithms { get; set; }
		public IEnumerable<ITableGenerator> TableGenerators { get; set; }
		public IEnumerable<int> TableSizes { get; set; }

		public SortsTestWithGivenTableSizes(
			IEnumerable<ISortingAlgorithm> algorithms,
			IEnumerable<ITableGenerator> tableGenerators,
			IEnumerable<int> tableSizes)
		{
			Algorithms = algorithms;
			TableGenerators = tableGenerators;
			TableSizes = tableSizes;
		}

		public List<SortTestCase> Build()
		{
			var tests = new List<SortTestCase>();
			foreach (var generator in TableGenerators)
			{
				foreach (var size in TableSizes)
				{
					var tab = generator.Generate(size);
					foreach (var algorithm in Algorithms)
					{
						tests.Add(new SortTestCase(algorithm, (int[])tab.Clone(), generator));
					}
				}
			}
			return tests;
		}
	}
}
