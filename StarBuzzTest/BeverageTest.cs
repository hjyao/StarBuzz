using StarBuzz;
using Xunit;

namespace StarBuzzTest
{
    public class BeverageTest
    {
        [Fact]
        public void should_get_description_of_house_blend()
        {
            var houseBlend = new HouseBlend("Best house blend!");
            Assert.Equal("Best house blend!", houseBlend.GetDescription());
        }

        [Fact]
        public void should_get_description_of_dark_roast()
        {
            var darkRoast = new DarkRoast("Best dark roast!");
            Assert.Equal("Best dark roast!", darkRoast.GetDescription());
        }

        [Fact]
        public void should_get_description_of_decaf()
        {
            var decaf = new Decaf("Best decaf!");
            Assert.Equal("Best decaf!", decaf.GetDescription());
        }

        [Fact]
        public void should_get_description_of_espresso()
        {
            var espresso = new Espresso("Best espresso!");
            Assert.Equal("Best espresso!", espresso.GetDescription());
        }

        [Fact]
        public void should_compute_the_cost_of_house_blend()
        {
            var houseBlend = new HouseBlend("");
            Assert.Equal(10, houseBlend.Cost());
        }
        [Fact]
        public void should_compute_the_cost_of_dark_roast()
        {
            var darkRoast = new DarkRoast("");
            Assert.Equal(12, darkRoast.Cost());
        }
        [Fact]
        public void should_compute_the_cost_of_decaf()
        {
            var decaf = new Decaf("");
            Assert.Equal(14, decaf.Cost());
        }
        [Fact]
        public void should_compute_the_cost_of_espresso()
        {
            var espresso = new Espresso("");
            Assert.Equal(16, espresso.Cost());
        }
    }
}
