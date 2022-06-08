namespace SortingAlgorithmsTest.Sorts.Algorithms
{
	internal class SelectionSort : ISortingAlgorithm
	{
		public void Sort(int[] tab)
		{
			for (var i = 0; i < tab.Length; i++)
			{
				var minIndex = i;
				for (var j = i + 1; j < tab.Length; j++)
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
