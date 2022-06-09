namespace SortingAlgorithmsTest.TestTools.DataStructures
{
	internal readonly struct SortTestResult
	{
		public readonly SortTestCase testCase;
		public readonly long ticks;

		public SortTestResult(SortTestCase testCase, long ticks)
		{
			this.testCase = testCase;
			this.ticks = ticks;
		}

		public override string ToString()
		{
			return $"{testCase}\t{ticks}";
		}
	}
}
