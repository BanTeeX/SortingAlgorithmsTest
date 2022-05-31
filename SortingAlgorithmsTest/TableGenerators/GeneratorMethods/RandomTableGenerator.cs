namespace SortingAlgorithmsTest.TableGenerator.GeneratorMethods
{
	internal class RandomTableGenerator : ITableGenerator
	{
		public int[] Generate(int size)
		{
			var tab = new int[size];
			var random = new Random();

			for (int i = 0; i < tab.Length; i++)
			{
				tab[i] = random.Next(tab.Length);
			}

			return tab;
		}

		public override string ToString()
		{
			return "Random";
		}
	}
}
