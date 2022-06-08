namespace SortingAlgorithmsTest.TableGenerators.GeneratorMethods
{
	internal class VShapedTableGenerator : ITableGenerator
	{
		public int[] Generate(int size)
		{
			var tab = new int[size];
			var halfIndex = tab.Length / 2;

			var j = 0;
			for (var i = halfIndex; i >= 0; i--)
			{
				tab[i] = j;
				if (halfIndex + j < tab.Length)
				{
					tab[halfIndex + j] = j;
				}
				j++;
			}

			return tab;
		}

		public override string ToString()
		{
			return "V-shaped";
		}
	}
}
