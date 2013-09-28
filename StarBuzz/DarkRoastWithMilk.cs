namespace StarBuzz
{
    public class DarkRoastWithMilk
    {
        private readonly DarkRoast darkRoast;
        private const double cost = 5;

        public DarkRoastWithMilk(DarkRoast darkRoast)
        {
            this.darkRoast = darkRoast;
        }

        public double Cost()
        {
            return  darkRoast.Cost() + cost;
        }
    }
}