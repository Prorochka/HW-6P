using System;
using System.Collections.Generic;

namespace HW_6P
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar hyena = new Bar { Drinks = new List<Drink>(), Fagots = new Team { Name = "fagots", Members = new List<Visitor>() }, Bastards = new Team { Name = "bastards", Members = new List<Visitor>() } };
            Console.WriteLine($"Alcoholics come to the bar, and Alan says to them: \"Let's play a game\"");
            hyena.MenuGenerator();
            Console.WriteLine($"\"10 fagots will fight 10 bastards. Who are they? - \"");
            Console.WriteLine($"fagots:");
            hyena.TeamsGenerator(hyena.Fagots.Members);
            Console.WriteLine($"bastards:");
            hyena.TeamsGenerator(hyena.Bastards.Members);
            hyena.Competition();
        }
    }
}
