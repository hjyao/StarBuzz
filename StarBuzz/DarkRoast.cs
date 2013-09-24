namespace StarBuzz
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(string description) : base(description)
        {
        }

        public override double Cost()
        {
            return 12;
        }
    }
}