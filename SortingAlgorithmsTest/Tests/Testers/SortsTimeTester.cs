using SortingAlgorithmsTest.Sorts;
using SortingAlgorithmsTest.Tests.DataStructures;
using System.Diagnostics;

namespace SortingAlgorithmsTest.Tests.Testers
{
	internal class SortsTimeTester : ISortsTester<SortTestCase, SortTestResult>
	{
		public SortTestResult RunTest(SortTestCase testCase)
		{
			var stopwatch = Stopwatch.StartNew();
			testCase.testTable.SortTab(testCase.algorithm);
			stopwatch.Stop();
			return new SortTestResult(testCase, stopwatch.ElapsedTicks);
		}
	}
}
