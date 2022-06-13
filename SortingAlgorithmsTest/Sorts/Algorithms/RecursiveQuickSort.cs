namespace SortingAlgorithmsTest.Sorts.Algorithms
{
	public class RecursiveQuickSort : QuickSortBase, ISortingAlgorithm
	{
		public RecursiveQuickSort() : base() { }

		public RecursiveQuickSort
			(Func<int[], int, int, int> pivotDeterminant,
			string pivotDeterminantDescription) : base(pivotDeterminant, pivotDeterminantDescription) { }

		public void Sort(int[] tab)
		{
			InnerSort(tab, 0, tab.Length - 1);
		}

		private void InnerSort(int[] tab, int left, int right)
		{
			var pivot = _pivotDeterminant(tab, left, right);
			var i = left;
			var j = right;

			while (true)
			{
				while (i <= right && tab[i] < pivot)
				{
					i++;
				}

				while (j >= left && tab[j] > pivot)
				{
					j--;
				}

				if (i > j)
				{
					break;
				}

				tab.Swap(i, j);
				i++;
				j--;
			}

			if (left < j)
			{
				InnerSort(tab, left, j);
			}

			if (right > i)
			{
				InnerSort(tab, i, right);
			}
		}

		public override string ToString()
		{
			return $"Recursice quick {_pivotDeterminantDescription}";
		}
	}
}