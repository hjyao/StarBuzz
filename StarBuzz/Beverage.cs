namespace StarBuzz
{
    public abstract class Beverage
    {
        public bool Milk { get; set; }
        public bool Sugar { get; set; }

        public virtual double Cost()
        {
            var cost = 0.00;
                
            if (Milk)
            {
                cost += 5.00;
            }

            if (Sugar)
            {
                cost += 5.00;
            }
            return cost;
        }
    }
}