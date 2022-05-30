using SortingAlgorithmsTest.TableGenerator.GeneratorMethods;

namespace SortingAlgorithmsTest.TableGenerator
{
	public static class TableGenerators //TODO - dodać IEnumerable
	{
		public static ITableGenerator SortedAscending => new SortedAscendingTableGenerator();
		public static ITableGenerator SortedDescending => new SortedDescendingTableGenerator();
		public static ITableGenerator Constant => new ConstantTableGenerator();
		public static ITableGenerator VShaped => new VShapedTableGenerator();
		public static ITableGenerator Random => new RandomTableGenerator();
	}
}
