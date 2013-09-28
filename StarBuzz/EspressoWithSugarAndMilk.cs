namespace StarBuzz
{
    public class EspressoWithSugarAndMilk
    {
        private readonly Espresso espresso;
        private const double cost = 10;

        public EspressoWithSugarAndMilk(Espresso espresso)
        {
            this.espresso = espresso;
        }

        public double Cost()
        {
            return espresso.Cost() + cost;
        }
    }
}