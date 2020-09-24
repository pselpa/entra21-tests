using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace entra21_tests
{
    public class ArrayList1Test
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

    }
}        