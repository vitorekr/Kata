namespace MarsRoverComplete.Directions
{
    public class East : IDirection
    {
        public Position MoveForward(Position position) => new Position(position.X + 1, position.Y);
        public string AsStringCommand()
        {
            return "E";
        }

        public IDirection ToRight() => new South();

        public IDirection ToLeft() => new North();
    }
}