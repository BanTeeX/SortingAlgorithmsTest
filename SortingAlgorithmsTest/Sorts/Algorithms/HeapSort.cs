namespace SortingAlgorithmsTest.Sorts.Algorithms
{
	internal class HeapSort : ISortingAlgorithm
	{
		public void Sort(int[] tab)
		{
			for (int heapSize = tab.Length; heapSize > 1; heapSize--)
			{
				Heapify(tab, heapSize);
				tab.Swap(0, heapSize - 1);
			}
		}

		private void Heapify(int[] tab, int heapSize)
		{
			for (int i = heapSize - 1; i >= 0; i--)
			{
				int leftIndex = 2 * i + 1;
				int rightIndex = 2 * i + 2;
				int maxIndex = i;

				if (leftIndex < heapSize && tab[leftIndex] > tab[maxIndex])
				{
					maxIndex = leftIndex;
				}

				if (rightIndex < heapSize && tab[rightIndex] > tab[maxIndex])
				{
					maxIndex = rightIndex;
				}

				if (i != maxIndex)
				{
					tab.Swap(i, maxIndex);
					i = maxIndex + 1; //TODO - do poprawy
				}
			}
		}

		public override string ToString()
		{
			return "Heap";
		}
	}
}