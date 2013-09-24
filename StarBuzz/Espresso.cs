namespace StarBuzz
{
    public class Espresso : Beverage
    {
        public Espresso(string description) : base(description)
        {
        }

        public override double Cost()
        {
            return 16;
        }
    }
}