namespace StarBuzz
{
    public abstract class Beverage
    {
        private const double milkCost = 5.00;
        private const double sugarCost = 5.00;

        protected Beverage(bool hasMilk, bool hasSugar)
        {
            HasMilk = hasMilk;
            HasSugar = hasSugar;
        }

        public bool HasMilk { get; private set; }

        public bool HasSugar { get; private set; }

        public virtual double Cost()
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
            return cost;
        }
    }
}