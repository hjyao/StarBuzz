﻿using StarBuzz;
using Xunit;

namespace StarBuzzTest
{
    public class BeverageTest
    {

        [Fact]
        public void should_compute_the_cost_of_dark_roast()
        {
            var darkRoast = new DarkRoast();
            Assert.Equal(10, darkRoast.Cost());
        }
        [Fact]
        public void should_compute_the_cost_of_espresso()
        {
            var espresso = new Espresso();
            Assert.Equal(10, espresso.Cost());
        }
    }
}
