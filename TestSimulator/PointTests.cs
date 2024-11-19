using Simulator;
public class PointTests
{
    [Fact]
    public void Constructor_ShouldSetCoordinates()
    {
        var point = new Point(3, 4);
        Assert.Equal(3, point.X);
        Assert.Equal(4, point.Y);
    }
    [Theory]
    [InlineData(3, 4, Direction.Up, 3, 5)]
    [InlineData(3, 4, Direction.Right, 4, 4)]
    [InlineData(3, 4, Direction.Down, 3, 3)]
    [InlineData(3, 4, Direction.Left, 2, 4)]
    public void Next_ShouldReturnCorrectPoint(int x, int y, Direction d, int expectedX, int expectedY)
    {
        var point = new Point(x, y);
        var nextPoint = point.Next(d);
        Assert.Equal(new Point(expectedX, expectedY), nextPoint);
    }
    [Theory]
    [InlineData(3, 4, Direction.Up, 4, 5)]
    [InlineData(3, 4, Direction.Right, 4, 3)]
    [InlineData(3, 4, Direction.Down, 2, 3)]
    [InlineData(3, 4, Direction.Left, 2, 5)]
    public void NextDiagonal_ShouldReturnCorrectPoint(int x, int y, Direction d, int expectedX, int expectedY)
    {
        var point = new Point(x, y);
        var nextPoint = point.NextDiagonal(d);
        Assert.Equal(new Point(expectedX, expectedY), nextPoint);
    }
}