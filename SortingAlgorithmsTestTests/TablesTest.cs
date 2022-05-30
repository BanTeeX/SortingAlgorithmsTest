using SortingAlgorithmsTest.TableGenerator;
using SortingAlgorithmsTest.TableGenerator.GeneratorMethods;

namespace SortingAlgorithmsTestTests
{
	public class TablesTest
	{
		[Theory, ClassData(typeof(TablesTestData))]
		public void TableGeneratorTest(int[] expectedTab, ITableGenerator generator)
		{
			Assert.Equal(expectedTab, generator.Generate(expectedTab.Length));
		}

		[Fact]
		public void ConstantTableTest()
		{
			var tab = TableGenerators.Constant.Generate(10);

			bool isGood = true;
			for (int i = 0; i < tab.Length - 1; i++)
			{
				if (tab[i] != tab[i + 1])
				{
					isGood = false;
				}
			}

			Assert.True(isGood && 10 == tab.Length);
		}

		[Fact]
		public void RandomTableTest()
		{
			var tab = TableGenerators.Random.Generate(10);

			Assert.True(10 == tab.Length);
		}
	}
}
