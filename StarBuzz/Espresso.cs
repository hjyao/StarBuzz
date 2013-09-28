namespace StarBuzz
{
    public class Espresso : Beverage                                      
    {
        private const double cost = 10;

        public override double Cost()
        {
            return cost;
        }
    }
}