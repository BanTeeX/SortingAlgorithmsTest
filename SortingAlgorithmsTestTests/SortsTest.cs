using SortingAlgorithmsTest.Sorts.Algorithms;
using SortingAlgorithmsTest.TableGenerators;

namespace SortingAlgorithmsTestTests
{
	public class SortsTest
	{
		[Theory, ClassData(typeof(SortsTestData))]
		public void SortTest(ISortingAlgorithm algorithm)
		{
			var tab = GenerateRandomTable(24231);
			tab.SortTab(algorithm.Sort);
			Assert.True(IsTableSorted(tab));
		}

		private static int[] GenerateRandomTable(int size)
		{
			return TableGeneratorsInstances.AShaped.Generate(size);

			//int[] table = new int[size];
			//var random = new Random();
			//for (int i = 0; i < table.Length; i++)
			//{
			//	table[i] = random.Next(100);
			//}
			//return table;
		}

		private static bool IsTableSorted(int[] tab)
		{
			for (int i = 0; i < tab.Length - 1; i++)
			{
				if (tab[i] > tab[i + 1])
				{
					return false;
				}
			}
			return true;
		}
	}
}