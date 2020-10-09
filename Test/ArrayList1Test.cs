using Xunit;


namespace first_arrays_list_tests
{
    public class Test
    {
        [Theory]
        [InlineData(new int[5]{1, 2, 3, 4, 5}, new int[5]{1, 2, 3, 4, 5}, new int[5]{0, 0, 0, 0, 0})]
        [InlineData(new int[5]{-1, -2, -3, -4, -5}, new int[5]{1, 2, 3, 4, 5}, new int[5]{-2, -4, -6, -8, -10})]
        [InlineData(new int[5]{8, 6, 22, -78, 56}, new int[5]{0, 74, 5, -78, 12}, new int[5]{8, -68, 17, 0, 44})]
        public void should_return_the_result_array(int[] listA, int[] listB, int[] expected)
        {
            // Dado / Setup
            var exercises = new ArrayList1();

            // Quando / Ação
            int[] returnedValue = exercises.Exercise1(listA, listB);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }


        [Theory]
        [InlineData(new int[10]{5, 2, 27, 63, 41, 8, -15, 0, 70, 36}, new int[10]{5, 2, 27, 63, 41, 8, -15, 0, 70, 36}, new int[10]{36, 70, 0, -15, 8, 41, 63, 27, 2, 5})]
        public void should_return_the_array_and_its_reversed_version(int[] array, int[] expected, int[] expectedReversed)
        {
            // Dado / Setup
            var exercises = new ArrayList1();

            // Quando / Ação
            (int[], int[]) returnedValue = exercises.Exercise2(array);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue.Item1);
            Assert.Equal(expectedReversed, returnedValue.Item2);
        }


        [Theory]
        [InlineData(new int[4]{5, 12, 7, 0}, 12, true)]
        [InlineData(new int[4]{98, -5, 78, 0}, 78, true)]
        [InlineData(new int[4]{-20, 41, 654, 23}, 9, false)]
        public void should_return_if_a_number_exists_in_an_array(int[] listA, int searchNumber, bool expected)
        {
            // Dado / Setup
            var exercises = new ArrayList1();

            // Quando / Ação
            bool returnedValue = exercises.Exercise3(listA, searchNumber);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }


        [Theory]
        [InlineData(new int[5]{5, 9, -3, 7, 22}, new int[5]{9, -3, 22, 5, 7}, true)]
        [InlineData(new int[5]{12, 0, 78, 122, -55}, new int[5]{-43, 0, 78, 122, 12}, false)]
        public void should_return_if_two_arrays_are_equal(int[] listA, int[] listB, bool expected)
        {
            // Dado / Setup
            var exercises = new ArrayList1();

            // Quando / Ação
            bool returnedValue = exercises.Exercise4(listA, listB);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }


        [Theory]
        [InlineData(new int[5]{5, 10, 15, 20, 25}, 1, 2, 2)]
        [InlineData(new int[5]{-6, 82, 41, 27, 0}, 0, 2, 3)]
        [InlineData(new int[5]{34, 42, 16, 5, 27}, 0, 3, 2)]
        public void should_return_the_amount_of_numbers_on_average_above_average_an_under_average(int[] listA, int expectedOnAverage, int expectedAboveAverage, int expectedUnderAverage)
        {
            // Dado / Setup
            var exercises = new ArrayList1();

            // Quando / Ação
            (int, int, int) returnedValue = exercises.Exercise5(listA);

            // Deve / Asserções
            Assert.Equal(expectedOnAverage, returnedValue.Item1);
            Assert.Equal(expectedAboveAverage, returnedValue.Item2);
            Assert.Equal(expectedUnderAverage, returnedValue.Item3);
        }


        [Theory]
        [InlineData(new int[5]{5, 7, 2, -5, 0}, new int[5]{8, 9, 2, 1, 4}, new int[5]{-5, 0, 2, 5, 7}, new int[5]{9, 8, 4, 2, 1}, new int[5]{4, 6, 7, 8, 8})]
        public void should_return_the_ordered_listA_reversed_listB_and_ordered_listC(int[] listA, int[] listB, int[] expectedA, int[] expectedB, int[] expectedC)
        {
            // Dado / Setup
            var exercises = new ArrayList1();

            // Quando / Ação
            (int[], int[], int[]) returnedValue = exercises.Exercise6(listA, listB);

            // Deve / Asserções
            Assert.Equal(expectedA, returnedValue.Item1);
            Assert.Equal(expectedB, returnedValue.Item2);
            Assert.Equal(expectedC, returnedValue.Item3);
        }
    }
}        