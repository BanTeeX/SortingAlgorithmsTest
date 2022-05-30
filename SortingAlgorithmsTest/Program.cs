using SortingAlgorithmsTest.Sorts;
using SortingAlgorithmsTest.TableGenerator;

Console.WriteLine("Hello, World!");
var tasks = new List<Task>();
var tab = TableGenerators.Random.Generate(1000);
var tab1 = new int[1000];
var tab2 = new int[1000];
var tab3 = new int[1000];
var tab4 = new int[1000];
tab.CopyTo(tab1, 0);
tab.CopyTo(tab2, 0);
tab.CopyTo(tab3, 0);
tab.CopyTo(tab4, 0);
tasks.Add(Task.Run(() => tab1.SortTab(Sorts.InsertionSort)));
tasks.Add(Task.Run(() => tab2.SortTab(Sorts.SelectionSort)));
tasks.Add(Task.Run(() => tab3.SortTab(Sorts.CocktailSort)));
tasks.Add(Task.Run(() => tab4.SortTab(Sorts.HeapSort)));
