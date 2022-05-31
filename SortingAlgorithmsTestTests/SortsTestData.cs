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
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
