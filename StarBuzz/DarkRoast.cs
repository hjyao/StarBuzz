namespace StarBuzz
{
    public class DarkRoast : Beverage
    {
        private double darkRoastCost = 10.00;

        public DarkRoast(bool hasMilk, bool hasSugar)
        {
            HasMilk = hasMilk;
            HasSugar = hasSugar;
        }

        private const double milkCost = 5.00;
        private const double sugarCost = 5.00;
        public bool HasMilk { get; private set; }

        public bool HasSugar { get; private set; }

        public override double Cost()
        {
            if (HasMilk)
            {
                darkRoastCost += milkCost;
            }

            if (HasSugar)
            {
                darkRoastCost += sugarCost;
            }
            return darkRoastCost;
        }
    }
}