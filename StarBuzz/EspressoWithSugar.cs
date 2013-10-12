namespace StarBuzz
{
    class EspressoWithSugar : Espresso
    {
        private const double SugarCost = 5.00;

        public override  double Cost()
        {
            return 10.00 + SugarCost;
        }
    }
}
