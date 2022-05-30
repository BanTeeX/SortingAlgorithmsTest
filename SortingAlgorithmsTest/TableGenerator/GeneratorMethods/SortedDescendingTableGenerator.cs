namespace SortingAlgorithmsTest.TableGenerator.GeneratorMethods
{
	internal class SortedDescendingTableGenerator : ITableGenerator
	{
		public int[] Generate(int size)
		{
			var tab = new int[size];

			for (int i = 0; i < tab.Length; i++)
			{
				tab[i] = tab.Length - 1 - i;
			}

			return tab;
		}
	}
}
