using SortingAlgorithmsTest.Tests.DataStructures;

namespace SortingAlgorithmsTest.Tests.Testers
{
	internal interface ISortsTester
	{
		public async Task<List<SortTestResult>> RunTestsAsync(IEnumerable<SortTestCase> tests)
		{
			var results = new List<SortTestResult>();

			var tasks = tests.Select(test => Task.Run(() => results.Add(RunTest(test)))).ToArray();
			await Task.WhenAll(tasks);

			return results;
		}

		public SortTestResult RunTest(SortTestCase testCase);
	}
}
