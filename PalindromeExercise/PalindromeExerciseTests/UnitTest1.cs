using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]

        [InlineData("racecar", true)]
        [InlineData ("null", false)]
        [InlineData("civic", true)]
        [InlineData("bull", false)]
        public void Test1(string word , bool expected)
        {
            var test = new WordSmith();

            bool actual = test.IsAPalindrome(word);

           Assert.Equal(expected, actual);
        }
    }
}
