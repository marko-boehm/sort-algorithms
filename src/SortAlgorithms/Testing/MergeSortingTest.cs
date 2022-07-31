namespace Testing
{
    using SortAlgorithms.DivideAndConquerSortings;
    using Testing.Arrange;

    public class MergeSortingTest
    {
        [Fact]
        public void Sort_ArrayUnique1To10_Sorted()
        {
            var sortingAlgorithm = new MergeSorting();
            var actualSortedArray = sortingAlgorithm.Sort(RandomNumbersToSort.RandomNumbers_1to10_Unique);

            Assert.Equal(RandomNumbersToSort.ExpectedRandomNumers_1To10_Unique, actualSortedArray);
        }
    }
}