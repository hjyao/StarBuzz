namespace StarBuzz
{
    public class Espresso : Beverage                                      
    {
        private Sugar sugar;
        private Milk milk;
        private double cost = 10;

        public Espresso(string description) : base(description)
        {
        }

        public override double Cost()
        {
            if (sugar != null) {
                cost += sugar.Cost();
            }
            if (milk != null){
                cost += milk.Cost();
            }
            return cost;
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