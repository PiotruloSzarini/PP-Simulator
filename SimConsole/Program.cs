using Simulator;
using Simulator.Maps;
namespace SimConsole;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        SmallSquareMap map = new(5);
        List<Creature> creatures = new() { new Orc("Gorbag"), new Elf("Elandor") };
        List<Point> points = new() { new(2, 2), new(3, 1) };
        string moves = "dlrludl";
        Simulation simulation = new(map, creatures, points, moves);
        MapVisualizer mapVisualizer = new(simulation.Map);
        while (!simulation.Finished)
        {
            mapVisualizer.Draw();
            Console.WriteLine("\nPress any key to make a move...");
            Console.ReadKey(true);
            Console.Write($"{simulation.CurrentCreature.Info} {simulation.CurrentCreature.Position} goes {simulation.CurrentMoveName}\n");
            simulation.Turn();
        }
        mapVisualizer.Draw();
        Console.WriteLine("\nSimulation finished!");
    }
}