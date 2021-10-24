using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6P
{
    class Bar
    {
        public List<Drink> Drinks { get; set; }
        public List<Visitor> Fagots { get; set; }
        public List<Visitor> Bastards { get; set; }
        public void DrinkConstructor() 
        {
            Console.WriteLine("Enten drink name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter percent of alcohol in this drink:");
            double strength = Garson.GetNumberFromUser(3.3, 96.6);
            Console.WriteLine("Enter the volume this drink to be served (L):");
            double volume = Garson.GetNumberFromUser(0.1, 1);
            Drinks.Add(new Drink() { Title = name, Strength = strength, Volume = volume });
        }
        public void MenuGenerator()
        {
            Console.WriteLine("How many drinks are on the menu? Enter the number");
            int n = Garson.GetNumberFromUser(3, 10);
            for (int i = 0; i < n; i++)
            {
                DrinkConstructor();
            }
        }
        public void TeamsGenerator(List<Visitor>Visitors) 
        {
            for (int i = 0; i < 10; i++)
            {
                var c = new Random();
                int choseCl = c.Next(0, 4);
                if (choseCl == 0) { Console.WriteLine("this is an ordinary visitor"); }
                if (choseCl == 1) { Console.WriteLine("this is a tolchok"); }
                if (choseCl == 2) { Console.WriteLine("this is a stalker"); }
                if (choseCl == 3) { Console.WriteLine("this is a biker"); }
                Console.WriteLine("Enten visitor name:");
                string name = Console.ReadLine();
                double st = Garson.Randomaiser(20,60);
                if (choseCl == 0) { Visitors.Add(new Visitor() { Name = name, Stamina = st }); }
                if (choseCl == 1) { Visitors.Add(new Tolchok() { Name = name, Stamina = st }); }
                if (choseCl == 2) { Visitors.Add(new Stalker() { Name = name, Stamina = st }); }
                if (choseCl == 3) { Visitors.Add(new Biker() { Name = name, Stamina = st }); }
            }
        }
        public bool ConsciousnessTest(List<Visitor> Visitors) 
        {
            bool Loose = false;
            int a = 0;
            foreach (Visitor Visitor in Visitors)
            {
                if (Visitor.InConsciousness == false) { a++; }
            }
            if (a == 10) 
            {
                Loose = true;
                Console.WriteLine($"{Visitors} are lost");
            }
            return Loose;
        }
        public int FindParticipant(int Round, List<Visitor> Visitors) 
        {
            var i = Round - 1;
            if (Visitors[i].InConsciousness == false)
            {
                while (Visitors[i].InConsciousness == true)
                {
                    if (i == 9)
                    {
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return i;
        }
        public void Competition() 
        {
            int Round = 1;
            bool FagotsL = false;
            bool BastardsL = false;
            while (!FagotsL || !BastardsL)
            {
                Console.WriteLine($"Round {Round}");
                var f = FindParticipant(Round, Fagots);
                var b = FindParticipant(Round, Bastards);
                Console.WriteLine($"{Fagots[f].GetType()} {Fagots[f].Name} vs {Bastards[b].GetType()} {Bastards[b].Name}");
                var d = Garson.Randomaiser(0, Drinks.Count);
                Console.WriteLine($"{Drinks[d].Volume}L {Drinks[d].Title} ({Drinks[d].Strength})");
                Fagots[f].GetDrink(Drinks[d]);
                Bastards[b].GetDrink(Drinks[d]);
                if (Round == 10)
                {
                    Round = 1;
                }
                else
                {
                    Round = Round++;
                }
                FagotsL = ConsciousnessTest(Fagots);
                BastardsL = ConsciousnessTest(Bastards);
            }                       
        }
    }
}
