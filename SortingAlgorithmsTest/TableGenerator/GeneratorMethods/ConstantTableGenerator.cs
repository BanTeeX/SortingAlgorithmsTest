namespace SortingAlgorithmsTest.TableGenerator.GeneratorMethods
{
	internal class ConstantTableGenerator : ITableGenerator
	{
		public int[] Generate(int size)
		{
			var tab = new int[size];
			var random = new Random();
			int number = random.Next(1000);

			for (int i = 0; i < tab.Length; i++)
			{
				tab[i] = number;
			}

			return tab;
		}
	}
}
