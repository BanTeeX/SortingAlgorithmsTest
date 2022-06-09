namespace SortingAlgorithmsTest.TestTools.Testers
{
	internal abstract class SortsTesterBase<TTestCase, TTestResult>
	{
		public List<TTestResult> RunTests(IEnumerable<TTestCase> tests, IProgress<ProgressReport> progress)
		{
			var results = new List<TTestResult>();
			ProgressReport report;
			report.todo = tests.Count();

			Parallel.ForEach(tests, test =>
			{
				results.Add(RunTest(test));
				report.done = results.Count;
				progress.Report(report);
			});

			return results;
		}

		public abstract TTestResult RunTest(TTestCase testCase);
	}
}
