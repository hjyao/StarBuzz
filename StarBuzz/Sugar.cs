﻿namespace StarBuzz
{
    public class Sugar : Condiment
    {
        public const double cost = 5;

        public Sugar(Beverage beverage)
        {
            this.beverage = beverage;
        }

    }
}