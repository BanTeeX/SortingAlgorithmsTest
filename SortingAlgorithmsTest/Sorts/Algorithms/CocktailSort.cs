namespace SortingAlgorithmsTest.Sorts.Algorithms
{
	internal class CocktailSort : ISortingAlgorithm
	{
		public void Sort(int[] tab)
		{
			var swapped = true;
			var leftPoint = 0;
			var rightPoint = tab.Length - 1;

			while (swapped)
			{
				swapped = false;

				for (int i = leftPoint; i < rightPoint; i++)
				{
					if (tab[i] > tab[i + 1])
					{
						tab.Swap(i, i + 1);
						swapped = true;
					}
				}

				if (!swapped)
				{
					break;
				}

				swapped = false;
				rightPoint--;

				for (int i = rightPoint; i > leftPoint; i--)
				{
					if (tab[i] < tab[i - 1])
					{
						tab.Swap(i, i - 1);
						swapped = true;
					}
				}

				leftPoint++;
			}
		}
	}
}