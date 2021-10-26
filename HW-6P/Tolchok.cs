using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6P
{
    public class Tolchok : Visitor
    {
        public bool Zombie { get; set; } = false;
        public override void Action(Drink Drink, List<Visitor> Visitors, int e)
        {
            Console.WriteLine($"{GetType()} {Name} clinks with glass on the {Visitors[e].Name}'s forehead");
            GetDrink(Drink);
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
