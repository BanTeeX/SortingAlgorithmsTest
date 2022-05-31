using SortingAlgorithmsTest.Tests.DataStructures;

namespace SortingAlgorithmsTest.Tests.Savers
{
	internal class TxtFileSaver : ISortTestResultSaver<IEnumerable<SortTestResult>>
	{
		private readonly string _path;

		public TxtFileSaver(string path)
		{
			_path = path;
		}

		public async Task SaveAsync(IEnumerable<SortTestResult> results)
		{
			string output = "";
			foreach (var result in results)
			{
				output += result + "\n";
			}
			await File.WriteAllTextAsync(_path, output);
		}
	}
}
