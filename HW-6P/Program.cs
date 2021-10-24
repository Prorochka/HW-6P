using System;
using System.Collections.Generic;

namespace HW_6P
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar hyena = new Bar { Drinks = new List<Drink>(), Fagots = new List<Visitor>(), Bastards = new List<Visitor>()};
            hyena.MenuGenerator();
            hyena.TeamsGenerator(hyena.Fagots);
            hyena.TeamsGenerator(hyena.Bastards);
            hyena.Competition();
        }
    }
}
