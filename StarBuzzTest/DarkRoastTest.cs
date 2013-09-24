using StarBuzz;
using Xunit;

namespace StarBuzzTest
{
    public class DarkRoastTest
    {
        [Fact]
        public void should_create_dark_roast_with_milk_sugar()
        {
            var darkRoast = new DarkRoast("darkRoast");
            darkRoast.Add(new Sugar());
            darkRoast.Add(new Milk());

            var totalAmount = darkRoast.Cost();

            Assert.Equal(20.00, totalAmount);
        }

        [Fact]
        public void should_create_dark_roast_with_sugar()
        {
            var darkRoast = new DarkRoast("darkRoast");
            darkRoast.Add(new Sugar());

            var totalAmount = darkRoast.Cost();

            Assert.Equal(15.00, totalAmount);
        }

        [Fact]
        public void should_create_dark_roast_with_milk()
        {
            var darkRoast = new DarkRoast("darkRoast");
            darkRoast.Add(new Milk());

            var totalAmount = darkRoast.Cost();

            Assert.Equal(15.00, totalAmount);
        }
    }

}