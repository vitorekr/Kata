namespace MarsRoverComplete.Directions
{
    public static class DirectionFactory
    {

        public static IDirection CreateDirectionFrom(string direction)
        {
            return direction switch
            {
                "N" => new North(),
                "W" => new West(),
                "E" => new East(),
                "S" => new South(),
                _ => throw new NotSupportedException($"Direction {direction} is not supported"),
            };
        }
    }
}