namespace SortingAlgorithmsTest.Tests.Savers
{
	internal interface ISortTestResultSaver<TTestResult>
	{
		Task SaveAsync(TTestResult result);
	}
}
