namespace SortingAlgorithmsTest.Sorts.Algorithms
{
	internal class InsertionSort : ISortingAlgorithm
	{
		public void Sort(int[] tab)
		{
			for (int i = 0; i < tab.Length - 1; i++)
			{
				if (tab[i] < tab[i + 1])
				{
					continue;
				}

				for (int j = i + 1; j > 0 && tab[j] < tab[j - 1]; j--)
				{
					tab.Swap(j, j - 1);
				}
			}
		}
	}
}