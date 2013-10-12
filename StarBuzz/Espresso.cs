namespace StarBuzz
{
    public class Espresso : Beverage                                      
    {
        public static Espresso CreateEspresso(bool hasMilk, bool hasSugar)
        {
            if (!hasMilk && !hasSugar)
            {
                return new Espresso();
            }
            if (!hasMilk)
            {
                return new EspressoWithSugar();
            }
            if (!hasSugar)
            {
                return new EspressoWithMilk();
            }
            return new EspressoWithMilkSugar();
        }

        protected Espresso()
        {
        }

        public override double Cost()
        {
            return 10.00;
        }
    }
}