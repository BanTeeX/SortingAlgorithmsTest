using SortingAlgorithmsTest.Tests.Builders;
using SortingAlgorithmsTest.Tests.Savers;
using SortingAlgorithmsTest.Tests.Testers;

namespace SortingAlgorithmsTest.Tests
{
	internal class SortsTestRunner<TTestCase, TTestResult>
	{
		private readonly ISortsTester<TTestCase, TTestResult> _tester;
		private readonly ISortsTestBuilder<List<TTestCase>> _testBuilder;
		private readonly ISortTestResultSaver<IEnumerable<TTestResult>> _saver;

		public SortsTestRunner(
			ISortsTester<TTestCase, TTestResult> tester,
			ISortsTestBuilder<List<TTestCase>> builder,
			ISortTestResultSaver<IEnumerable<TTestResult>> saver)
		{
			_tester = tester;
			_testBuilder = builder;
			_saver = saver;
		}

		public async Task Run(IProgress<ProgressReport> progress)
		{
			var tests = _testBuilder.Build();
			var results = await _tester.RunTestsAsync(tests, progress);
			await _saver.SaveAsync(results);
		}
	}
}
