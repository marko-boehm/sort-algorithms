namespace Testing
{
    using SortAlgorithms.SimpleSortings;
    using Testing.Arrange;

    public class InsertionSortingTest
    {
        [Fact]
        public void Sort_ArrayUnique1To10_Sorted()
        {
            var sortingAlgorithm = new InsertionSorting();
            var actualSortedArray = sortingAlgorithm.Sort(RandomNumbersToSort.RandomNumbers_1to10_Unique);

            Assert.Equal(RandomNumbersToSort.ExpectedRandomNumers_1To10_Unique, actualSortedArray);
        }
    }
}