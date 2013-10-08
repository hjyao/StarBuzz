namespace StarBuzz
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(bool hasMilk, bool hasSugar): base(hasMilk, hasSugar)
        {
            
        }

        private const double cost = 10;

        public override double Cost()
        {
            return cost + base.Cost();
        }
    }
}