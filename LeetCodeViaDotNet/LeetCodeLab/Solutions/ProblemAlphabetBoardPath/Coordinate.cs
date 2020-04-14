namespace LeetCodeLab.Solutions.ProblemAlphabetBoardPath
{
    public class Coordinate : ICoordinate
    {

        public int CoordinateX { get;private set; }

        public int CoordinateY{ get;private set; }


        public void SetCoordinate(int coordinateX ,int coordinateY)
        {
            SetCoordinateX(coordinateX);
            SetCoordinateY(coordinateY);
        }

        public void SetCoordinateX(int coordinateX)
        {
            if(coordinateX != CoordinateX)
            {
                CoordinateX = coordinateX;
            }
        }

        public void SetCoordinateY(int coordinateY)
        {
            if(coordinateY != CoordinateY)
            {
                CoordinateY = coordinateY;
            }
        }

        public int GetCoordinateX()
        {
            return CoordinateX;
        }

        public int GetCoordinateY()
        {
            return CoordinateY;
        }
    }
}
