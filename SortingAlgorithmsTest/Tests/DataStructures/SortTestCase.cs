using SortingAlgorithmsTest.Sorts.Algorithms;
using SortingAlgorithmsTest.TableGenerator.GeneratorMethods;

namespace SortingAlgorithmsTest.Tests.DataStructures
{
	internal readonly struct SortTestCase
	{
		public readonly ISortingAlgorithm algorithm;
		public readonly int[] testTable;
		public readonly ITableGenerator generator;

		public SortTestCase(ISortingAlgorithm algorithm, int[] testTable, ITableGenerator generator)
		{
			this.algorithm = algorithm;
			this.testTable = testTable;
			this.generator = generator;
		}

		public override string ToString()
		{
			return $"{algorithm}\t{generator}\t{testTable.Length}";
		}
	}
}
