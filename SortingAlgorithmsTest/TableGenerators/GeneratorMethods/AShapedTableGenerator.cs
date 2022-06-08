namespace SortingAlgorithmsTest.TableGenerators.GeneratorMethods
{
	internal class AShapedTableGenerator : ITableGenerator
	{
		public int[] Generate(int size)
		{
			var tab = new int[size];

			for (var i = 0; i < (float)tab.Length / 2; i++)
			{
				tab[i] = i;
				tab[tab.Length - 1 - i] = i;
			}

			return tab;
		}

		public override string ToString()
		{
			return "A-shaped";
		}
	}
}
