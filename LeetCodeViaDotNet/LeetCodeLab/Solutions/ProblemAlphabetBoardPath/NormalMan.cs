using System.Text;

namespace LeetCodeLab.Solutions.ProblemAlphabetBoardPath
{
    public class NormalMan : AbstractRunningMan , IMoveCoordinate
    {
        private readonly char moveUPSymbol = 'U';
        private readonly char moveDownSymbol = 'D';
        private readonly char moveLeftSymbol = 'L';
        private readonly char moveRightSymbol = 'R';

        private StringBuilder _stringBuilder;

        public NormalMan()
        {
            _stringBuilder = new StringBuilder();
        }

        public void SetStringBuilder(StringBuilder stringBuilder)
        {
            _stringBuilder = stringBuilder;
        }

        public void SetCurrentAlphabetCoordinate(ICoordinate currentCoordinate)
        {
            this.CurrentAlphabetCoordinate = currentCoordinate;
        }

        public void SetPreviousAlphabetCoordinate(ICoordinate previousCoordinate)
        {
            this.PreviousAlphabetCoordinate = previousCoordinate;
        }

        public IMoveCoordinate MoveUp()
        {
            var previousY = this.PreviousAlphabetCoordinate.GetCoordinateY();
            var currentY = this.CurrentAlphabetCoordinate.GetCoordinateY();
            while(previousY > currentY)
            {
                _stringBuilder.Append(moveUPSymbol);
                previousY--;
                this.PreviousAlphabetCoordinate.SetCoordinateY(previousY);
            }

            return this;
        }

        public IMoveCoordinate MoveDown()
        {
            var previousY = this.PreviousAlphabetCoordinate.GetCoordinateY();
            var currentY = this.CurrentAlphabetCoordinate.GetCoordinateY();
            while(previousY < currentY)
            {
                _stringBuilder.Append(moveDownSymbol);
                previousY++;
                this.PreviousAlphabetCoordinate.SetCoordinateY(previousY);
            }

            return this;
        }

        public IMoveCoordinate MoveRight()
        {
            var previousX = this.PreviousAlphabetCoordinate.GetCoordinateX();
            var currentX = this.CurrentAlphabetCoordinate.GetCoordinateX();
            while(previousX < currentX)
            {

                _stringBuilder.Append(moveRightSymbol);
                previousX++;
                this.PreviousAlphabetCoordinate.SetCoordinateX(previousX);
            }

            return this;
        }
        public IMoveCoordinate MoveLeft()
        {
            var previousX = this.PreviousAlphabetCoordinate.GetCoordinateX();
            var currentX = this.CurrentAlphabetCoordinate.GetCoordinateX();
            while(previousX > currentX)
            {
                _stringBuilder.Append(moveLeftSymbol);
                previousX--;
                this.PreviousAlphabetCoordinate.SetCoordinateX(previousX);
            }

            return this;
        }

        public string GetDestinyOutPut()
        {
            return _stringBuilder.ToString();
        }
    }
}
