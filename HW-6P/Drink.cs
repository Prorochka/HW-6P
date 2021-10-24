namespace HW_6P
{
    public class Drink
    {
        public string Title { get; set; }
        public double Strength { get; set; }
        public double Volume { get; set; }
        public double Damage
        {
            get
            {
                var Damage = Strength * Volume;
                return Damage;
            }
        }
    }
}