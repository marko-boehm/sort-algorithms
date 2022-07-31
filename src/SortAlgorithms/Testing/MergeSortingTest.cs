namespace Testing
{
    using SortAlgorithms.DivideAndConquerSortings;

    public class MergeSortingTest
    {
        [Fact]
        public void Sort_Array_Sorted()
        {
            var sortingAlgorithm = new MergeSorting();
            var actualSortedArray = sortingAlgorithm.Sort(RandomNumbersToSort.RandomNumbers_1to10_Unique);

            Assert.Equal(RandomNumbersToSort.ExpectedRandomNumers_1To10_Unique, actualSortedArray);
        }
    }
}