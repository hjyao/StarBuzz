namespace StarBuzz
{
    public class DarkRoastWithMilkAndSugar
    {
        private readonly DarkRoast darkRoast;
        private const double cost = 10;

        public DarkRoastWithMilkAndSugar(DarkRoast darkRoast)
        {
            this.darkRoast = darkRoast;
        }

        public double Cost()
        {
            return  darkRoast.Cost() + cost;
        }
    }
}