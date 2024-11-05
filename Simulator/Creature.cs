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
            name = value.Trim();
            if (name.Length < 3)
            {
                name = name.PadRight(3, '#');
            }
            if (name.Length > 25)
            {
                name = name.Substring(0, 25);
                name = name.Trim();
                if (name.Length < 3)
                {
                    name = name.PadRight(3, '#');
                }
            }
            name = char.ToUpper(name[0]) + name.Substring(1);
        }
    }
    public int Level
    {
        get => level;
        init
        {
            level = value < 1 ? 1 : value > 10 ? 10 : value;
        }
    }
    public abstract int Power { get; }
    public Creature() { }
    public Creature(string name, int level = 1)
    {
        Name = name;
        Level = level >= 1 ? level : 1;
    }

    public void SayHi() => Console.WriteLine($"Hi, I'm {Name}, my level is {Level}.");
    public int Upgrade() => level < 10 ? ++level : level;
    public void Go(Direction direction)
    {
        Console.WriteLine($"{name} goes {direction.ToString().ToLower()}.");
    }
    public void Go(Direction[] directions)
    {
        foreach (var direction in directions)
        {
            Go(direction);
        }
    }
    public void Go(string directions)
    {
        var parsedDirections = DirectionParser.Parse(directions);
        Go(parsedDirections);
    }
    public string Info => $"{Name} [{Level}]";
}
public class Elf : Creature
{
    private int agility = 1;
    private int SingCounter = 0;
    public int Agility { get => agility; init => agility = value < 0 ? 0 : value > 10 ? 10 : value; }
    public override int Power => 8 * Level + 2 * Agility;
    public void Sing()
    {
        SingCounter++;
        Console.WriteLine($"{Name} is singing.");
        if (SingCounter % 3 == 0)
        {
            if (agility < 10)
            {
                agility++;
            }
        }
    }
    public Elf() { }
    public Elf(string name = "Unknown Elf", int level = 1, int agility = 1) : base(name, level)
    {
        Agility = agility;
    }
}
public class Orc : Creature
{
    private int rage = 1;
    private int HuntCounter = 0;
    public int Rage { get => rage; init => rage = value < 0 ? 0 : value > 10 ? 10 : value; }
    public override int Power => 7 * Level + 3 * Rage;
    public void Hunt()
    {
        HuntCounter++;
        Console.WriteLine($"{Name} is hunting.");
        if (HuntCounter % 2 == 0)
        {
            if (rage < 10)
            {
                rage++;
            }
        }
    }
    public Orc() { }
    public Orc(string name = "Unknown Orc", int level = 1, int rage = 1) : base(name, level)
    {
        Rage = rage;
    }
}