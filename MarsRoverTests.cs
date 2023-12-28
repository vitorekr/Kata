namespace MarsRoverComplete
{
    public class MarsRoverTests
    {       
        [Theory]
        [InlineData("0:0:N", "", "0:0:N")]
        [InlineData("2:3:W", "", "2:3:W")]
        [InlineData("0:0:N", "M", "0:1:N")]
        [InlineData("1:1:N", "M", "1:2:N")]
        [InlineData("1:1:W", "M", "0:1:W")]
        [InlineData("1:1:E", "M", "2:1:E")]
        [InlineData("1:1:S", "M", "1:0:S")]
        [InlineData("1:1:S", "R", "1:1:W")]
        [InlineData("1:1:W", "R", "1:1:N")]
        [InlineData("1:1:N", "R", "1:1:E")]
        [InlineData("1:1:E", "R", "1:1:S")]
        [InlineData("1:1:N", "L", "1:1:W")]
        [InlineData("1:1:W", "L", "1:1:S")]
        [InlineData("1:1:S", "L", "1:1:E")]
        [InlineData("1:1:E", "L", "1:1:N")]
        [InlineData("1:1:W", "LL", "1:1:E")]
        public void ExecuteCommands(string initialState, string commands, string expectedState)
        {
            //Arrange
            var marsRover = new MarsRover(initialState);

            //Act
            var result = marsRover.Execute(commands);

            //Assert
            Assert.Equal(expectedState, result);
        }
    }
}