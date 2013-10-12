namespace StarBuzz
{
    class EspressoWithMilkSugar : Espresso
    {
        private const double MilkCost = 5.00;
        private const double SugarCost = 5.00;

        public override double Cost()
        {
            return 10.00 + MilkCost + SugarCost;
        }
    }
}
