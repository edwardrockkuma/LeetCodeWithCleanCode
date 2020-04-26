using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using LeetCodeLab.Solutions.ProblemAlphabetBoardPath;
using LeetCodeLab.Solutions.Interface;
using CommonUtils.Helper;

namespace LeetCodeLab
{
    public class MainProgram
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {           
            var serviceProvider = ConfigureServices(new ServiceCollection()).BuildServiceProvider();           
            var logger = serviceProvider.GetRequiredService<ILogger<MainProgram>>();             
            var alphabetBoardPathSolution = CreateSolution(serviceProvider,logger);

            try
            {     
                string input = "code";
                logger.LogInformation($"AlphabetBoardPath Input is: {input}");            
                var solutionResult = alphabetBoardPathSolution.Execute(input);
                logger.LogInformation($"AlphabetBoardPath Output is: {solutionResult}");               
            }
            catch(Exception ex)
            {
                logger.LogError($"Exception: {ex.Message}",ex);
            }
            finally
            {
                serviceProvider.Dispose();    
            }

                  
        }

        public static ILeetCodeSolution CreateSolution(IServiceProvider serviceProvider,ILogger<MainProgram> logger)
        {
            ILeetCodeSolution alphabetBoardPathSolution;
            
            try
            {
                alphabetBoardPathSolution = serviceProvider.GetRequiredService<ILeetCodeSolution>();
                ICoordinate previousCoordinateDefault = new Coordinate();
                previousCoordinateDefault.SetCoordinate(0,0);
                alphabetBoardPathSolution.SetUpExtraData(previousCoordinateDefault);
                
            }
            catch(Exception ex)
            {
                logger.LogError($"Exception: {ex.Message}",ex);
                throw;
            }

            return alphabetBoardPathSolution;
        }

        /// <summary>
        /// Container of Dependency Injection
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureServices(IServiceCollection services)
        {
            return services
                .AddLogging(builder =>
                {
                    builder.AddConsole();
                })
                .Configure<LoggerFilterOptions>(options =>
                {
                    options.MinLevel = LogLevel.Information;
                })
                .AddScoped<ICoordinate,Coordinate>()
                .AddScoped<IMoveCoordinate, NormalMan>()
                .AddSingleton<ILeetCodeSolution , AlphabetBoardPathSolution>();
        }

    }
}
