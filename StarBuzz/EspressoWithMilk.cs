namespace StarBuzz
{
    public class EspressoWithMilk :Espresso
    {
        private double milkCost;

        public override double Cost()
        {
            milkCost = 5.00;
            return 10.00 + milkCost;
        }
    }
}