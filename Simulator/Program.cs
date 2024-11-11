﻿using Simulator.Maps;
namespace Simulator;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Simulator!\n");
        Point p = new(10, 25);
        Console.WriteLine(p.Next(Direction.Right));          // (11, 25)
        Console.WriteLine(p.NextDiagonal(Direction.Right));  // (11, 24) 
        Lab5a();
        /* 
        (2, 2); (5, 7)
        (2, 2); (5, 7)
        Punkty są współliniowe - chudy prostąkąt
        (3, 3); (7, 8)
        (5, 5) True
        */
        Lab5b();
        /*
        Rozmiar mapy: 10
        Czy (0, 0) należy do mapy: True
        Czy (-1, -1) należy do mapy: False
        Na prawo od (0, 0) znajduje się: (1, 0)
        W górę od (0, 0) znajduje się: (0, 1)
        (9, 9): (9, 9) <- Kraniec mapy
        Na skos od (0, 0) znajduje się: (1, 1)
        */
         }
         public static void Lab5a()
         {
            try
            {
             var rect1 = new Rectangle(2, 2, 5, 7);
             Console.WriteLine($"{rect1}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"{e.Message}");
            }
             try
             {
                var rect2 = new Rectangle(5, 7, 2, 2);
            Console.WriteLine($"{rect2}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"{e.Message}");
        }
        try
        {
            var rect3 = new Rectangle(1, 1, 1, 5);
            Console.WriteLine($"{rect3}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"{e.Message}");
        }
        try
        {
            var p1 = new Point(3, 3);
            var p2 = new Point(7, 8);
            var rect4 = new Rectangle(p1, p2);
            Console.WriteLine($"{rect4}");
            var testPoint = new Point(5, 5);
            Console.WriteLine($"{testPoint} {rect4.Contains(testPoint)}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"{e.Message}");
        }
    }
    static void Lab5b()
    {
        SmallSquareMap map = new SmallSquareMap(10);
        Console.WriteLine($"Rozmiar mapy: {map.Size}");
        Point startPoint = new Point(0, 0);
        Point outsidePoint = new Point(-1, -1);
        Console.WriteLine($"Czy {startPoint} należy do mapy: {map.Exist(startPoint)}"); // True
        Console.WriteLine($"Czy {outsidePoint} należy do mapy: {map.Exist(outsidePoint)}"); // False
        Point nextRight = map.Next(startPoint, Direction.Right);
        Point nextUp = map.Next(startPoint, Direction.Up);
        Console.WriteLine($"Na prawo od {startPoint} znajduje się: {nextRight}"); // (1, 0)
        Console.WriteLine($"W górę od {startPoint} znajduje się: {nextUp}"); // (0, 1)
        Point edgePoint = new Point(map.Size - 1, map.Size - 1);
        Point outOfBounds = map.Next(edgePoint, Direction.Right);
        Console.WriteLine($"{edgePoint}: {outOfBounds} <- Kraniec mapy");
        Point diagonal = map.NextDiagonal(startPoint, Direction.Up);
        Console.WriteLine($"Na skos od {startPoint} znajduje się: {diagonal}"); // Expected: (1, 1)
    }
}