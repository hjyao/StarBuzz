namespace StarBuzz
{
    public class Decaf : Beverage
    {
        public Decaf(string description) : base(description)
        {
        }

        public override double Cost()
        {
            return 14;
        }
    }
}