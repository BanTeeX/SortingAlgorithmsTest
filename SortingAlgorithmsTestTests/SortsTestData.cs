using System.Collections;

namespace SortingAlgorithmsTestTests
{
	internal class SortsTestData : IEnumerable<object[]>
	{
		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[] { Sorts.SelectionSort };
			yield return new object[] { Sorts.InsertionSort };
			yield return new object[] { Sorts.CocktailSort };
			yield return new object[] { Sorts.HeapSort };
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
