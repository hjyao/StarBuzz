namespace StarBuzz
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(string description) : base(description)
        {
        }

        public override double Cost()
        {
            return 10;
        }
    }
}