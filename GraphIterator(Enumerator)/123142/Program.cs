using System;
using System.Collections.Generic;


class App
{
    static void Main()
    {
        List<object> b = new List<object>
        {
            new List<object> {5, 9 },
            new List<object> {5, 10 },
            new List<object> {5, 11 },
        };
        List<object> a = new List<object>
        {
            new List<object> {1, 3 },
            new List<object> {1, 4 },
            new List<object> {1, b },
        };
        List<object> d = new List<object>
        {
            new List<object> {7, 12 },
            new List<object> {7, 13 },
        };
        List<object> c = new List<object>
        {
            new List<object> {2, 6 },
            new List<object> {2, d },
            new List<object> {2, 8 },
        };
        List<object> item = new List<object>
        {
            new List<object> {0, a },
            new List<object> {0, c },
        };

        Algorithm algorith = new Algorithm(new BFS());
        algorith.Start(item);
        Console.WriteLine("||------------------------||");
        algorith = new Algorithm(new DFS());
        algorith.Start(item);
    }
}
