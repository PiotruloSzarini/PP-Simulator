﻿namespace Simulator;

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
}