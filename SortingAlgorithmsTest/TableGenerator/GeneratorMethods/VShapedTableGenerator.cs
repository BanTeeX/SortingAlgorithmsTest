namespace SortingAlgorithmsTest.TableGenerator.GeneratorMethods
{
	internal class VShapedTableGenerator : ITableGenerator
	{
		public int[] Generate(int size)
		{
			var tab = new int[size];
			int halfIndex = tab.Length / 2;

			for (int i = halfIndex, j = 0; i >= 0; i--, j++)
			{
				tab[i] = j;
				tab[halfIndex + j] = j;
			}

			return tab;
		}
	}
}
