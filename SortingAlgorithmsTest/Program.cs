using SortingAlgorithmsTest.Sorts;
using SortingAlgorithmsTest.TableGenerator;
using SortingAlgorithmsTest.Tests.Builders;
using SortingAlgorithmsTest.Tests.Testers;

var tests = new SortsTestWithGivenTableSizes(
	new[] { Sorts.SelectionSort, Sorts.InsertionSort, Sorts.CocktailSort, Sorts.HeapSort },
	new[] { TableGenerators.SortedAscending, TableGenerators.SortedDescending, TableGenerators.Constant, TableGenerators.Random, TableGenerators.VShaped },
	new[] { 10 }).Build();
var results = await ((ISortsTester)new SortsTimeTester()).RunTestsAsync(tests);

Console.WriteLine("Sort\tTable\tSize\tTicks");
foreach (var result in results)
{
	Console.WriteLine(result);
}
