namespace SortingAlgorithmsTest.Sorts.Algorithms
{
	public class IterativeQuickSort : QuickSortBase, ISortingAlgorithm
	{
		public IterativeQuickSort() : base() {}

		public IterativeQuickSort
			(Func<int[], int, int, int> pivotDeterminant,
			string pivotDeterminantDescription) : base(pivotDeterminant, pivotDeterminantDescription) {}

		public void Sort(int[] tab)
		{
			Stack<(int left, int right)> subTabs = new();

			subTabs.Push((0, tab.Length - 1));

			while (subTabs.Count > 0)
			{
				var (left, right) = subTabs.Pop();
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
					subTabs.Push((left, j));
				}

				if (right > i)
				{
					subTabs.Push((i, right));
				}
			}
		}

		public override string ToString()
		{
			return $"Iterative quick {_pivotDeterminantDescription}";
		}
	}
}