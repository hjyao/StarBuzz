namespace StarBuzz
{
    public class EspressoWithSugar
    {
        private readonly Espresso espresso;
        private const double cost = 5;

        public EspressoWithSugar(Espresso espresso)
        {
            this.espresso = espresso;
        }

        public double Cost()
        {
            return espresso.Cost() + cost;
        }
    }
}