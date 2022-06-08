namespace SortingAlgorithmsTest.TableGenerators.GeneratorMethods
{
	internal class ConstantTableGenerator : ITableGenerator
	{
		public int[] Generate(int size)
		{
			var tab = new int[size];
			var random = new Random();
			var number = random.Next(tab.Length);

			for (var i = 0; i < tab.Length; i++)
			{
				tab[i] = number;
			}

			return tab;
		}

		public override string ToString()
		{
			return "Constant";
		}
	}
}
