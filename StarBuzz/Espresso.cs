namespace StarBuzz
{
    public class Espresso : Beverage                                      
    {
        public Espresso(bool hasMilk, bool hasSugar) : base(hasMilk, hasSugar)
        {
        }

        private const double cost = 10;

        public override double Cost()
        {
            return cost + base.Cost();
        }
    }
}