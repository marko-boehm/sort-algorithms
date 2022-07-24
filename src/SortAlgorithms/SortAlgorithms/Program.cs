// See https://aka.ms/new-console-template for more information
using SortAlgorithms;

Console.WriteLine("Comparison of sort algorithms");
Console.WriteLine("-----------------------------");

var randomNumbers = Enumerable.Range(1, 10000).OrderBy(n => Guid.NewGuid()).ToArray(); //100000

// Test - ToDo Implement Unit Tests
//randomNumbers = Enumerable.Range(1, 10).OrderBy(n => Guid.NewGuid()).ToArray();
//var sort = new BubbleSort();
//sort.Sort(randomNumbers);


List<ISort> sortAlgorithms = new List<ISort>();
sortAlgorithms.Add(new SelectionSort());
sortAlgorithms.Add(new InsertionSort());
sortAlgorithms.Add(new BubbleSort());
sortAlgorithms.Add(new ArraySortCSharp());

foreach (ISort sortAlgorithm in sortAlgorithms)
{
    sortAlgorithm.Sort(randomNumbers);
}



