using SortingAlgorithmsTest.Sorts;
using SortingAlgorithmsTest.Tests.DataStructures;
using System.Diagnostics;

namespace SortingAlgorithmsTest.Tests.Testers
{
	internal class SortsTimeTester : SortsTesterBase<SortTestCase, SortTestResult>
	{
		public override SortTestResult RunTest(SortTestCase testCase)
		{
			var stopwatch = Stopwatch.StartNew();
			testCase.testTable.SortTab(testCase.algorithm.Sort);
			stopwatch.Stop();
			return new SortTestResult(testCase, stopwatch.ElapsedTicks);
			
		}
	}
}
