using System;
using Xunit;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using LeetCodeLab;
using CommonUtils.Helper;

namespace LeetCode.Tests
{
    public class LeetCodeSolutionTest
    {
        [Theory]
        [InlineData("leet","RDD!UURRR!!DDD!")]
        [InlineData("code","RR!DDRR!UUL!R!")]   
        public void AlphabetBoardPathTest(string input,string expected)
        {
            // Arrange
            var serviceProvider = MainProgram.ConfigureServices(new ServiceCollection()).BuildServiceProvider();           
            var logger = serviceProvider.GetRequiredService<ILogger<MainProgram>>();             
            var solution = MainProgram.CreateSolution(serviceProvider,logger);
           
            // Act
            var output = solution.Execute(input);

            // Assert
            Assert.True(CheckPathPermutations(expected, output));
        }

        /// <summary>
        /// Because there'll be many permutations of path , so we check all of that. 
        /// </summary>
        /// <param name="testPath"></param>
        /// <param name="actualPath"></param>
        /// <returns></returns>
        private bool CheckPathPermutations(string testPath , string actualPath)
        {
            string[] testPathArray = testPath.Split('!',StringSplitOptions.RemoveEmptyEntries);
            string[] actualPathArray = actualPath.Split('!',StringSplitOptions.RemoveEmptyEntries);
            if(testPathArray.Length != actualPathArray.Length)
            {
                return false;
            }

            for (int i=0; i < testPathArray.Length; i++)
            {
                HashSet<string> testPathPermutations = new HashSet<string>();
                string oneStepOfTestPath = testPathArray[i];
                string oneStepOfActualPath = actualPathArray[i];
                PermutationsHelper.Permute(testPathPermutations , oneStepOfTestPath ,0 ,oneStepOfTestPath.Length-1);
                if(!testPathPermutations.Contains(oneStepOfActualPath))
                {
                    return false;
                }

            }
            

            return true;
        }
    }
}
