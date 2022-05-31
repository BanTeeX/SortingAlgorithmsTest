using SortingAlgorithmsTest.TableGenerators;
using System.Collections;

namespace SortingAlgorithmsTestTests
{
	internal class TablesTestData : IEnumerable<object[]>
	{
		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[] { new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, TableGeneratorsInstances.SortedAscending };
			yield return new object[] { new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, TableGeneratorsInstances.SortedDescending };
			yield return new object[] { new int[] { 5, 4, 3, 2, 1, 0, 1, 2, 3, 4 }, TableGeneratorsInstances.VShaped };
			yield return new object[] { new int[] { 5, 4, 3, 2, 1, 0, 1, 2, 3, 4, 5 }, TableGeneratorsInstances.VShaped };
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}