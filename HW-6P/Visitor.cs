using System;
using System.Collections.Generic;

namespace HW_6P
{
    public class Visitor
    {
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
        public virtual void Action(Drink Drink, List<Visitor> Visitors, int e) 
        {
            Console.WriteLine($"{GetType()} {Name} clinks with glass on the {Visitors[e].Name}'s forehead");
            GetDrink(Drink);
        }
    }
}