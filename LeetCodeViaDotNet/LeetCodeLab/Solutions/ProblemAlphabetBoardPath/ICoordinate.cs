namespace LeetCodeLab.Solutions.ProblemAlphabetBoardPath
{
    /// <summary>
    /// Coordinates data set up
    /// </summary>
    public interface ICoordinate
    {
        void SetCoordinate(int coordinateX ,int coordinateY);

        void SetCoordinateX(int coordinateX);

        void SetCoordinateY(int coordinateY);

        int GetCoordinateX();

        int GetCoordinateY();
    }
}
