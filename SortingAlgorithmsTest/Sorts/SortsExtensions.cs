namespace SortingAlgorithmsTest.Sorts
{
	public static class SortsExtensions
	{
		public static void SortTab(this int[] tab, ISortingAlgorithm algorithm)
		{
			algorithm.Sort(tab);
		}

		public static void Swap(this int[] tab, int index1, int index2)
		{
			if (index1 != index2)
			{
				(tab[index2], tab[index1]) = (tab[index1], tab[index2]);
			}
		}
	}
}
