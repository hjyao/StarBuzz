namespace StarBuzz
{
    public class Espresso : Beverage                                      
    {
        public Espresso(bool hasMilk, bool hasSugar)
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
            var cost = 0.00;

            if (HasMilk)
            {
                cost += milkCost;
            }

            if (HasSugar)
            {
                cost += sugarCost;
            }
            return cost + 10;
        }
    }
}