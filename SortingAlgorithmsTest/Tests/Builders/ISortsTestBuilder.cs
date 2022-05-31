namespace SortingAlgorithmsTest.Tests.Builders
{
	internal interface ISortsTestBuilder<TTestCase>
	{
		TTestCase Build();
	}
}