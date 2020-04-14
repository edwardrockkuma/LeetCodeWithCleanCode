

namespace LeetCodeLab.Solutions.ProblemAlphabetBoardPath
{
    /// <summary>
    /// Abstract a base struct that can be extended for different moving scenario
    /// </summary>
    public class AbstractRunningMan
    {
        public ICoordinate PreviousAlphabetCoordinate {get;protected set;}

        public ICoordinate CurrentAlphabetCoordinate {get;protected set;}



    }
}
