// See https://aka.ms/new-console-template for more information
using SortAlgorithms;
using SortAlgorithms.DivideAndConquerSortings;
using SortAlgorithms.SimpleSortings;


var randomNumbers = Enumerable.Range(1, 10000).OrderBy(n => Guid.NewGuid()).ToArray(); //100000

Console.WriteLine("Comparison of sort algorithms");
Console.WriteLine("-----------------------------");
Console.WriteLine($"Count of random numbers: {randomNumbers.Count()}\n");

//Test - ToDo Implement Unit Tests
//randomNumbers = Enumerable.Range(1, 10).OrderBy(n => Guid.NewGuid()).ToArray();
//var sort = new MergeSort();
//var sortedList = sort.Sort(randomNumbers);


List<ISort> sortAlgorithms = new List<ISort>();
sortAlgorithms.Add(new SelectionSort());
sortAlgorithms.Add(new InsertionSort());
sortAlgorithms.Add(new BubbleSort());
sortAlgorithms.Add(new MergeSort());
sortAlgorithms.Add(new ArraySortCSharp());

foreach (ISort sortAlgorithm in sortAlgorithms)
{
    sortAlgorithm.Sort(randomNumbers);
}



