using System;
using System.Collections.Generic;

namespace HW_6P
{
    public class Visitor
    {
        public virtual string Class { get; } = "Common Visitor";
        public string Name { get; set; }
        public double Stamina { get; set; }
        public bool InConsciousness { get; set; } = true;        
        public void GetDrink(Drink Drink) 
        { 
            Stamina -= Drink.Damage;
            if (Stamina <= 0) 
            {
                InConsciousness = false;
                Console.WriteLine($"{Name} lost consciousness");
            }

        }
        public virtual void Action(List<Drink> Drinks, int d, List<Visitor> Visitors, int e) 
        {
            Console.WriteLine($"{GetType()} {Name} clinks with glass on the {Visitors[e].Name}'s forehead");
            GetDrink(Drinks[d]);
        }
        public void GetTreated(List<Drink> Drinks) 
        {
            var d = Garson.Randomaiser(0, Drinks.Count);
            Console.WriteLine($"{Name} get {Drinks[d].Volume}L {Drinks[d].Title}");
            GetDrink(Drinks[d]);
        }
    }
}