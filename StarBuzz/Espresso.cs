namespace StarBuzz
{
    public class Espresso : Beverage                                      
    {
        private double espressoCost = 10.00;

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
            if (HasMilk)
            {
                espressoCost += milkCost;
            }

            if (HasSugar)
            {
                espressoCost += sugarCost;
            }
            return espressoCost;
        }
    }
}