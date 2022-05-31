using SortingAlgorithmsTest.Sorts.Algorithms;

namespace SortingAlgorithmsTest.Sorts
{
	public static class SortsInstances
	{
		public static ISortingAlgorithm SelectionSort => new SelectionSort();
		public static ISortingAlgorithm InsertionSort => new InsertionSort();
		public static ISortingAlgorithm CocktailSort => new CocktailSort();
		public static ISortingAlgorithm HeapSort => new HeapSort();
	}
}
