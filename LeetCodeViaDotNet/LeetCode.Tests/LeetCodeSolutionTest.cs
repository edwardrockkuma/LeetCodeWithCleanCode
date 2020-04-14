using System;
using Xunit;
using LeetCodeLab.Solutions.ProblemAlphabetBoardPath;
using System.Collections.Generic;

namespace LeetCode.Tests
{
    public class LeetCodeSolutionTest
    {
        [Theory]
        [InlineData("leet","RDD!UURRR!!DDD!")]
        [InlineData("code","RR!DDRR!UUL!R!")]
        public void AlphabetBoardPathTest(string input,string expected)
        {
            AlphabetBoardPathSolution solution = new AlphabetBoardPathSolution();

            var output = solution.AlphabetBoardPath(input);

            Assert.Equal(expected, output);
        }
    }
}
