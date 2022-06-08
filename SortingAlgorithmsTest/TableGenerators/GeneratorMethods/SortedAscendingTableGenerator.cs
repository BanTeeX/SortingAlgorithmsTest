namespace SortingAlgorithmsTest.TableGenerators.GeneratorMethods
{
	internal class SortedAscendingTableGenerator : ITableGenerator
	{
		public int[] Generate(int size)
		{
			var tab = new int[size];

			for (var i = 0; i < tab.Length; i++)
			{
				tab[i] = i;
			}

			return tab;
		}

		public override string ToString()
		{
			return "Sorted ascending";
		}
	}
}
