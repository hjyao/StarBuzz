namespace StarBuzz
{
    public class Condiment : Beverage
    {
        protected Beverage beverage;

        public override double Cost()
        {
            if(beverage is Milk)
                return beverage.Cost() + Milk.cost;
            return beverage.Cost() + Sugar.cost;
        }
    }
}