namespace SortingAlgorithmsTest.Sorts.Algorithms
{
	internal class HeapSort : ISortingAlgorithm
	{
		public void Sort(int[] tab)
		{
			Heapify(tab);
			for (int i = tab.Length - 1; i > 0; i--)
			{
				tab.Swap(0, i);
				for (int j = 0, index = 2 * j + 1; index < i; j = index)
				{
					if (tab[index] < tab[index + 1])
					{
						index++;
					}

					if (tab[j] < tab[index])
					{
						tab.Swap(j, index);
					}
				}
			}
		}

		private void Heapify(int[] tab)
		{
			for (int i = 1; i < tab.Length; i++)
			{
				if (tab[i] > tab[(i - 1) / 2])
				{
					for (int j = i; tab[j] > tab[(j - 1) / 2]; j = (j - 1) / 2)
					{
						tab.Swap(j, (j - 1) / 2);
					}
				}
			}
		}

		public override string ToString()
		{
			return "Heap";
		}
	}
}