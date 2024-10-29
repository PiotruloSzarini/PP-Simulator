
namespace Simulator
{
    internal class Creature
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private int level;
        public int Level { get { return level; } set { level = value; } }
        public Creature(string name, int level = 1)
        {
            Name = name;
            Level = level;
        }
        public Creature() { }
        public void SayHi()
        {
            Console.WriteLine($"Hi I'm {Name} and my level is {Level}");
        }
        public string Info
        {
            get { return $"{Name} [{Level}]"; }
        }
    }
}