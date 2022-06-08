namespace SortingAlgorithmsTest.Sorts.Algorithms
{
	public abstract class QuickSortBase
	{
		protected readonly Func<int[], int, int, int> _pivotDeterminant;
		protected readonly string _pivotDeterminantDescription;

		public QuickSortBase()
		{
			_pivotDeterminant = (tab, left, right) => tab[(left + right) / 2];
			_pivotDeterminantDescription = "Pivot middle";
		}

		public QuickSortBase(Func<int[], int, int, int> pivotDeterminant, string pivotDeterminantDescription)
		{
			_pivotDeterminant = pivotDeterminant;
			_pivotDeterminantDescription = pivotDeterminantDescription;
		}
	}
}