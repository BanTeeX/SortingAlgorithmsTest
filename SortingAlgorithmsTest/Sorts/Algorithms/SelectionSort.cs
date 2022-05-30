namespace SortingAlgorithmsTest.Sorts.Algorithms
{
	internal class SelectionSort : ISortingAlgorithm
	{
		public void Sort(int[] tab)
		{
			for (int i = 0; i < tab.Length; i++)
			{
				var minIndex = i;
				for (int j = i + 1; j < tab.Length; j++)
				{
					if (tab[j] < tab[minIndex])
					{
						minIndex = j;
					}
				}
				tab.Swap(i, minIndex);
			}
		}

		public override string ToString()
		{
			return "Selection";
		}
	}
}
