using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using LeetCodeLab.Solutions.ProblemAlphabetBoardPath;
using LeetCodeLab.Solutions.Interface;

namespace LeetCodeLab
{
    public class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            using(var svcs = ConfigureServices(new ServiceCollection()).BuildServiceProvider())
            {
                var logger = svcs.GetRequiredService<ILogger<Program>>();

                try
                {
                    var solution = svcs.GetRequiredService<ILeetCodeSolution>();
                    ICoordinate previousCoordinateDefault = new Coordinate();
                    previousCoordinateDefault.SetCoordinate(0,0);
                    solution.SetUpExtraData(previousCoordinateDefault);
                    solution.Execute();
                }
                catch(Exception ex)
                {
                    logger.LogError($"Exception: {ex.Message}",ex);
                }

            }

        }

        /// <summary>
        /// Container of Dependency Injection
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection ConfigureServices(IServiceCollection services)
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
