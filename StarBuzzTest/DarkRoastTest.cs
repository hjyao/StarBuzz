using StarBuzz;
using Xunit;

namespace StarBuzzTest
{
    public class DarkRoastTest
    {
        [Fact]
        public void should_compute_dark_roast_with_milk_sugar()
        {
            var darkRoast = new DarkRoast {Milk = true, Sugar = true};

            var totalAmount = darkRoast.Cost();

            Assert.Equal(20.00, totalAmount);
        }

        [Fact]
        public void should_compute_dark_roast_with_sugar()
        {
            var darkRoast = new DarkRoast {Sugar = true};

            var totalAmount = darkRoast.Cost();

            Assert.Equal(15.00, totalAmount);
        }

        [Fact]
        public void should_compute_dark_roast_with_milk()
        {
            var darkRoast = new DarkRoast {Milk = true};

            var totalAmount = darkRoast.Cost();

            Assert.Equal(15.00, totalAmount);
        }
    }
}