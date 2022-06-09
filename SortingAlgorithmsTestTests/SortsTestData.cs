using SortingAlgorithmsTest.Sorts.Algorithms;
using System.Collections;

namespace SortingAlgorithmsTestTests
{
	internal class SortsTestData : IEnumerable<object[]>
	{
		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[] { SortsInstances.SelectionSort };
			yield return new object[] { SortsInstances.InsertionSort };
			yield return new object[] { SortsInstances.CocktailSort };
			yield return new object[] { SortsInstances.HeapSort };
			yield return new object[] { SortsInstances.RecursiveQuickSort };
			yield return new object[] { SortsInstances.IterativeQuickSort };
			yield return new object[] { new RecursiveQuickSort((tab, left, right) => tab[right], "Pivot right") };
			yield return new object[] { new RecursiveQuickSort((tab, left, right) => { var random = new Random(); return tab[random.Next(left, right + 1)]; }, "Pivot random") };
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
