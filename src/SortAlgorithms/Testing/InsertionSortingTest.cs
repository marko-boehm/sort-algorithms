namespace Testing
{
    using SortAlgorithms.SimpleSortings;

    public class InsertionSortingTest
    {
        [Fact]
        public void Sort_Array_Sorted()
        {
            var sortingAlgorithm = new InsertionSorting();
            var actualSortedArray = sortingAlgorithm.Sort(RandomNumbersToSort.RandomNumbers_1to10_Unique);

            Assert.Equal(RandomNumbersToSort.ExpectedRandomNumers_1To10_Unique, actualSortedArray);
        }
    }
}