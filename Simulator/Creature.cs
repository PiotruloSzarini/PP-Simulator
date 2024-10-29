namespace Simulator;
internal class Creature
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
    public Creature() { }
    public Creature(string name, int level = 1)
    {
        Name = name;
        Level = level >= 1 ? level : 1;
    }

    public void SayHi() => Console.WriteLine($"Hi, I'm {Name}, my level is {Level}.");
    public int Upgrade() => level < 10 ? ++level : level;
    public string Info => $"{Name} [{Level}]";
}