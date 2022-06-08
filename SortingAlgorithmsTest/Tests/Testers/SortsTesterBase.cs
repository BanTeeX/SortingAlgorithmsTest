namespace SortingAlgorithmsTest.Tests.Testers
{
	internal abstract class SortsTesterBase<TTestCase, TTestResult>
	{
		public async Task<List<TTestResult>> RunTestsAsync(IEnumerable<TTestCase> tests, IProgress<ProgressReport> progress)
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

		public List<TTestResult> RunTests(IEnumerable<TTestCase> tests, IProgress<ProgressReport> progress)
		{
			var results = new List<TTestResult>();
			ProgressReport report;
			report.todo = tests.Count();

			foreach (var test in tests)
			{
				results.Add(RunTest(test));
				report.done = results.Count;
				progress.Report(report);
			}

			return results;
		}

		public abstract TTestResult RunTest(TTestCase testCase);
	}
}
