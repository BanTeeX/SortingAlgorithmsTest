using SortingAlgorithmsTest.TestTools.DataStructures;

namespace SortingAlgorithmsTest.TestTools.Savers
{
	internal class TxtFileSaver : ISortTestResultSaver<IEnumerable<SortTestResult>>
	{
		private readonly string _path;

		public TxtFileSaver(string path)
		{
			_path = path;
		}

		public void Save(IEnumerable<SortTestResult> results)
		{
			var output = "Algorithm\tGenerator\tLength\tTicks\n";
			foreach (var result in results)
			{
				output += result + "\n";
			}
			File.WriteAllText(_path, output);
		}
	}
}
