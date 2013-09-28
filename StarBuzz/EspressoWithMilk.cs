namespace StarBuzz
{
    public class EspressoWithMilk
    {
        private readonly Espresso espresso;
        private const double cost = 5;

        public EspressoWithMilk(Espresso espresso)
        {
            this.espresso = espresso;
        }

        public double Cost()
        {
            return espresso.Cost() + cost;
        }
    }
}