namespace StarBuzz
{
    public class DarkRoastWithSugar
    {
        private readonly DarkRoast darkRoast;
        private const double cost = 5;

        public DarkRoastWithSugar(DarkRoast darkRoast)
        {
            this.darkRoast = darkRoast;
        }

        public double Cost()
        {
            return darkRoast.Cost() + cost;
        }
    }
}