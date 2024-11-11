namespace Simulator.Maps;
internal class SmallSquareMap : Map
{
    public int Size { get; }
    private Rectangle boundaries;
    public override bool Exist(Point p)
    {
        return boundaries.Contains(p);
    }
    public override Point Next(Point p, Direction d)
    {
        Point nextPoint = p.Next(d);
        return Exist(nextPoint) ? nextPoint : p;
    }
    public override Point NextDiagonal(Point p, Direction d)
    {
        Point nextPoint = p.NextDiagonal(d);
        return Exist(nextPoint) ? nextPoint : p;
    }
    public SmallSquareMap(int size)
    {
        if (size < 5 || size > 20)
            throw new ArgumentOutOfRangeException(nameof(size), "Rozmiar mapy musi być pomiędzy 5 a 20.");
        Size = size;
        boundaries = new Rectangle(0, 0, Size - 1, Size - 1);
    }
}