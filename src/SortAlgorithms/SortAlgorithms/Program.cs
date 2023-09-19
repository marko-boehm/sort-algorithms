// See https://aka.ms/new-console-template for more information
using SortAlgorithms;
using SortAlgorithms.DivideAndConquerSortings;
using SortAlgorithms.SimpleSortings;
using SortAlgorithms.TreeSortings;

var randomNumbers = Enumerable.Range(1, 100000).OrderBy(n => Guid.NewGuid()).ToArray(); //100000

Console.WriteLine("Comparison of sort algorithms");
Console.WriteLine("-----------------------------");
Console.WriteLine($"Count of random numbers: {randomNumbers.Count()}\n");

//randomNumbers = new int[] { 2, 7, 3, 5, 4, 9, 10, 6, 8, 1 };
//var binSearchTree = new BinarySearchTree();
//binSearchTree.AddData(randomNumbers);
//var arr = binSearchTree.InOrder();

//randomNumbers = Enumerable.Range(1, 100).OrderBy(n => Guid.NewGuid()).ToArray();
//var sort = new BubbleSortingImproved();
//var sortedList = sort.Sort(randomNumbers);

List<ISort> sortAlgorithms = new List<ISort>();
sortAlgorithms.Add(new SelectionSorting());
sortAlgorithms.Add(new InsertionSorting());
sortAlgorithms.Add(new BubbleSorting());
sortAlgorithms.Add(new BubbleSortingV2());
sortAlgorithms.Add(new MergeSorting());
sortAlgorithms.Add(new QuickSorting());
sortAlgorithms.Add(new BinaryTreeSorting());
sortAlgorithms.Add(new ArraySortingCSharp());

foreach (ISort sortAlgorithm in sortAlgorithms)
{
    sortAlgorithm.Sort(randomNumbers);
}



