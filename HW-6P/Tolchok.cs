using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6P
{
    public class Tolchok : Visitor
    {
        public override string Class { get; } = "Tolchok";
        public bool Zombie { get; set; } = false;
        public override void Action(List<Drink> Drinks, int d, List<Visitor> Visitors, int e)
        {
            Console.WriteLine($"{GetType()} {Name} clinks with glass on the {Visitors[e].Name}'s forehead");
            GetDrink(Drinks[d]);
            ResurrectionByErection();
        }
        public void ResurrectionByErection()
        {
            if (Zombie == false && InConsciousness == false)
            {
                Stamina = 10;
                Zombie = true;
                Console.WriteLine($"{Name} is resurrected");
            }
        }
    }
}
