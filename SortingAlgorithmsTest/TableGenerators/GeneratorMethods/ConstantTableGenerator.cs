namespace SortingAlgorithmsTest.TableGenerator.GeneratorMethods
{
	internal class ConstantTableGenerator : ITableGenerator
	{
		public int[] Generate(int size)
		{
			var tab = new int[size];
			var random = new Random();
			int number = random.Next(tab.Length);

			for (int i = 0; i < tab.Length; i++)
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
