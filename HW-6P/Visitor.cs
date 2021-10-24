using System;

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
    }
}