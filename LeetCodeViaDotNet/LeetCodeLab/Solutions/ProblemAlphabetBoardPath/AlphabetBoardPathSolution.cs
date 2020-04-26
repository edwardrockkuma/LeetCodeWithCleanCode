using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CommonUtils.UnitTest;
using Microsoft.Extensions.Logging;
using LeetCodeLab.Solutions.Interface;

namespace LeetCodeLab.Solutions.ProblemAlphabetBoardPath
{
    /// <summary>
    /// Solution of the leetcode problem: Alphabet Board Path
    /// </summary>
    public class AlphabetBoardPathSolution : ILeetCodeSolution
    {
        private ILogger<AlphabetBoardPathSolution> _log;

        private IMoveCoordinate _movingMan;

        private ICoordinate _currentCoordinate;

        private ICoordinate _previousCoordinate;

        public AlphabetBoardPathSolution(ILogger<AlphabetBoardPathSolution> log
            ,IMoveCoordinate movingMan,ICoordinate currentCoordinate)
        {
            _log = log;
            _movingMan = movingMan;
            _currentCoordinate = currentCoordinate;

        }

        public void SetUpExtraData<T>(T previousCoordinateDefault)
        {
            _previousCoordinate = previousCoordinateDefault as ICoordinate;

        }


        public string AlphabetBoardPath(string target)
        {
            char answerSymbol = '!';
            int previousX = 0, previousY = 0;

            StringBuilder stringBuilder = new StringBuilder();
            char alphabetA = 'a';
            _previousCoordinate.SetCoordinate(previousX , previousY);
            _movingMan.SetPreviousAlphabetCoordinate(_previousCoordinate);

            foreach(char alphabetNow in target)
            {

                // Get coordinate via ASCII table
                int currentX = (alphabetNow - alphabetA)%5;
                int currentY = (alphabetNow - alphabetA)/5;

                _currentCoordinate.SetCoordinate(currentX , currentY);
                _movingMan.SetCurrentAlphabetCoordinate(_currentCoordinate);
                _movingMan.SetStringBuilder(stringBuilder);


                if(currentX == previousX && currentY == previousY)
                {
                    stringBuilder.Append(answerSymbol);
                }
                else
                {
                    // Moving order is important
                    _movingMan.MoveUp()
                        .MoveRight()
                        .MoveLeft()
                        .MoveDown();
                    stringBuilder.Append(answerSymbol);
                    previousX = currentX;
                    previousY = currentY;
                    _previousCoordinate.SetCoordinate(previousX , previousY);


                }
            }

            var output = _movingMan.GetDestinyOutPut();
            //_log.LogInformation($"Solution output: {output}");
            return output;
        }


        public string Execute(string input)
        {
            string output = "";
            
            try 
            {                 
                output = AlphabetBoardPath(input);
            }
            catch (Exception ex)
            {
                _log.LogError($"AlphabetBoardPathSolution - Execute() - Exception: {ex.Message}");
                return output;
                throw;
            }

            return output;
        }     
    }
}
