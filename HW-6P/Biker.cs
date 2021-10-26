using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6P
{
    public class Biker : Visitor
    {
        public bool Bountiful { get; set; } = true;
        public override void Action(List<Drink> Drinks, int d, List<Visitor> Visitors, int e)
        {
            Console.WriteLine($"{Name} get {Drinks[d].Volume}L {Drinks[d].Title}");
            GetDrink(Drinks[d]);
            Banquet(Drinks, Visitors, e);
        }
        public void Banquet(List<Drink> Drinks, List<Visitor> Visitors, int e) 
        {
            int a = 0;
            foreach (Visitor Visitor in Visitors)
            {
                if (Visitor.InConsciousness == false) { a++; }
            }
            if (InConsciousness == true && Bountiful ==true && a >= 3)
            {
                Console.WriteLine($"{GetType()} {Name} decided to treat friends");
                Visitors[e].GetTreated(Drinks);
                var e1 = FindFriend(Visitors);
                Visitors[e1].GetTreated(Drinks);
                var e2 = FindFriend(Visitors);
                Visitors[e2].GetTreated(Drinks);
                GetTreated(Drinks);
                Bountiful = false;
            }
        }
        public int FindFriend (List<Visitor> Visitors) 
        {
            var i = Garson.Randomaiser(0, 10);
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
    }
}
