using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6P
{
    public class Biker : Visitor
    {
        public bool Bountiful { get; set; } = true;
        public override void Action(Drink Drink, List<Visitor> Visitors, int e)
        {
            GetDrink(Drink);
        }
        public void Banquet(List<Visitor> Visitors, int e) 
        {
            if (InConsciousness == true && Bountiful ==true && Visitors[e].InConsciousness == true)
            {
                var d = Garson.Randomaiser(0, 4);
                var e1 = Garson.Randomaiser(0, 10);
                var e2 = Garson.Randomaiser(0, 10);

            }
        }
    }
}
