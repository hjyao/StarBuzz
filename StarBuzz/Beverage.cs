namespace StarBuzz
{
    public abstract class Beverage
    {
        private readonly string description;

        protected Beverage(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}