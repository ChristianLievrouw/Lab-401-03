using System;
using Lab03;
using Xunit;

namespace Lab03Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new[] {1, 2, 3, 4, 5}, 6)]
        [InlineData(new[] {2, 3}, 0)]
        [InlineData(new[] {-2, -5, -6}, -60)]
        public void Product_multi_all_nums_in_array(int[] inputArray, int expected)
        {
            //Act
            int result = Program.Product(inputArray);

            //Assert
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 3, 4, 5 }, 1)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }, 1)]
        [InlineData(new[] { 1, 1, 1, 1 }, 1)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 1)]
        public void Challenge4_finds_most_freq(int[] arr, int expected)
        {
            //Act
            int result = Program.Challenge4(arr);
            //Assert
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 3, 4, 5 }, 5)]
        public void Challenge5_finds_max(int[] arr, int expected)
        {
            //Act
            int result = Program.ChallengeFive(arr);
            //Assert
            Assert.Equal(result, expected);
        }
    }
}
