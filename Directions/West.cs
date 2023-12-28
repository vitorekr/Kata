namespace MarsRoverComplete.Directions
{
    public class West : IDirection
    {

        public Position MoveForward(Position position) => new Position(position.X - 1, position.Y);
        public string AsStringCommand()
        {
            return "W";
        }

        public IDirection ToRight() => new North();

        public IDirection ToLeft() => new South();
    }
}