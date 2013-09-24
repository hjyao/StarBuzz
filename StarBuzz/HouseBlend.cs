namespace StarBuzz
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(string description) : base(description)
        {
        }

        public void Add(Sugar sugar)
        {
            this.sugar = sugar;
        }

        public void Add(Milk milk)
        {
            this.milk = milk;
        }
    }
}