namespace SortingAlgorithmsTest.Tests.Testers
{
	internal interface ISortsTester<TTestCase, TTestResult>
	{
		async Task<List<TTestResult>> RunTestsAsync(IEnumerable<TTestCase> tests, IProgress<ProgressReport> progress)
		{
			var results = new List<TTestResult>();
			ProgressReport report;
			report.todo = tests.Count();

			await Task.Run(() =>
			{
				Parallel.ForEach(tests, test =>
				{
					results.Add(RunTest(test));
					report.done = results.Count;
					progress.Report(report);
				});
			});

			return results;
		}

		TTestResult RunTest(TTestCase testCase);
	}
}
