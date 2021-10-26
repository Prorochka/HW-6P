using System;
using System.Collections.Generic;

namespace HW_6P
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar hyena = new Bar { Drinks = new List<Drink>(), Fagots = new List<Visitor>(), Bastards = new List<Visitor>()};
            Console.WriteLine($"Alcoholics come to the bar, and Alan says to them: \"Let's play a game\"");
            hyena.MenuGenerator();
            Console.WriteLine($"\"10 fagots will fight 10 bastards. Who are they? - \"");
            Console.WriteLine($"fagots:");
            hyena.TeamsGenerator(hyena.Fagots);
            Console.WriteLine($"bastards:");
            hyena.TeamsGenerator(hyena.Bastards);
            hyena.Competition();
        }
    }
}
