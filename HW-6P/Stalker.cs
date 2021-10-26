using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6P
{
    public class Stalker : Visitor
    {
        public bool Hit { get; set; } = false;
        public override void Action(Drink Drink, List<Visitor> Visitors, int e)
        {
            Hitting(Visitors, e);
            GetDrink(Drink);
        }
        public void Hitting(List<Visitor> Visitors, int e) 
        {
            var h = Garson.Randomaiser(0,2);
            if (h == 1 && Hit == false)
            {
                Console.WriteLine($"{GetType()} {Name} hits {Visitors[e].Name} with a bottle on the head.");
                Visitors[e].Stamina -= 5;
                Hit = true;
            } 
        }
    }
}
