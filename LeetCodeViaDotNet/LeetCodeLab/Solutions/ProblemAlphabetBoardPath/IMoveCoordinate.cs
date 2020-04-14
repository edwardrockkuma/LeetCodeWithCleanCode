using System.Text;
namespace LeetCodeLab.Solutions.ProblemAlphabetBoardPath
{
    /// <summary>
    /// Define coordinates moving behaviour
    /// </summary>
    public interface IMoveCoordinate
    {
        void SetStringBuilder(StringBuilder stringBuilder);

        void SetCurrentAlphabetCoordinate(ICoordinate currentCoordinate);

        void SetPreviousAlphabetCoordinate(ICoordinate previousCoordinate);

        IMoveCoordinate MoveUp();

        IMoveCoordinate MoveDown();

        IMoveCoordinate MoveRight();

        IMoveCoordinate MoveLeft();

        string GetDestinyOutPut();
    }
}
