namespace Simulator;

public abstract class Creature
{
    private int level = 1;
    private string name = "Unknown";

    public string Name
    {
        get => name;
        init
        {
            name = Validator.Shortener(value, 3, 25, '#');
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }
    }
    public int Level
    {
        get => level;
        init => level = Validator.Limiter(value, 1, 10);
    }
    public abstract int Power { get; }
    public Creature() { }
    public Creature(string name, int level = 1)
    {
        Name = name;
        Level = level >= 1 ? level : 1;
    }

    public string Greeting() => $"Hi, I'm {Name}, my level is {Level}.";
    public int Upgrade() => level < 10 ? ++level : level;
    public string Go(Direction direction) => $"{direction.ToString().ToLower()}";
    public string[] Go(Direction[] directions)
    {
       var result = new string[directions.Length];
        for (int i = 0; i < directions.Length; i++)
        {
            result[i] = Go(directions[i]);
        }
        return result;
    }
    public string[] Go(string directionSeq) => Go(DirectionParser.Parse(directionSeq));
    public abstract string Info { get; }
     public override string ToString() => $"{GetType().Name.ToUpper()}: {Info}";
}

