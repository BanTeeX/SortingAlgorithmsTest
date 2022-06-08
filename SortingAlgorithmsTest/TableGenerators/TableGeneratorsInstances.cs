using SortingAlgorithmsTest.TableGenerators.GeneratorMethods;

namespace SortingAlgorithmsTest.TableGenerators
{
	public static class TableGeneratorsInstances
	{
		public static ITableGenerator SortedAscending => new SortedAscendingTableGenerator();
		public static ITableGenerator SortedDescending => new SortedDescendingTableGenerator();
		public static ITableGenerator Constant => new ConstantTableGenerator();
		public static ITableGenerator VShaped => new VShapedTableGenerator();
		public static ITableGenerator Random => new RandomTableGenerator();
		public static ITableGenerator AShaped => new AShapedTableGenerator();
	}
}
