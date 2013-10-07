namespace StarBuzz
{
    public class Milk : Condiment
    {
        public const double cost = 5;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}