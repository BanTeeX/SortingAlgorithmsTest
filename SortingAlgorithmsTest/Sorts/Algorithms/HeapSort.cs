namespace SortingAlgorithmsTest.Sorts.Algorithms
{
	internal class HeapSort : ISortingAlgorithm
	{
		public void Sort(int[] tab)
		{
			Heapify(tab);
			for (var i = tab.Length - 1; i >= 0; i--)
			{
				tab.Swap(0, i);
				var index = 1;
				var j = 0;
				while (index < i)
				{
					if (index < i - 1 && tab[index] < tab[index + 1])
					{
						index++;
					}

					if (tab[j] < tab[index])
					{
						tab.Swap(j, index);
					}

					j = index;
					index = 2 * j + 1;
				}
			}
		}

		private static void Heapify(int[] tab)
		{
			for (var i = 1; i < tab.Length; i++)
			{
				if (tab[i] > tab[(i - 1) / 2])
				{
					for (var j = i; tab[j] > tab[(j - 1) / 2]; j = (j - 1) / 2)
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