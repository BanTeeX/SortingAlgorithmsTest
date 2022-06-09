namespace SortingAlgorithmsTest.TestTools.Savers
{
	internal interface ISortTestResultSaver<TTestResult>
	{
		void Save(TTestResult result);
	}
}
