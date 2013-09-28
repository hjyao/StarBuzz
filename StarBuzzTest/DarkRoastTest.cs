using StarBuzz;
using Xunit;

namespace StarBuzzTest
{
    public class DarkRoastTest
    {
        [Fact]
        public void should_create_dark_roast_with_milk_sugar()
        {
            var darkRoast = new DarkRoast();
            var darkRoastWithMilkAndSugar = new DarkRoastWithMilkAndSugar(darkRoast);
            var totalAmount = darkRoastWithMilkAndSugar.Cost();

            Assert.Equal(20.00, totalAmount);
        }

        [Fact]
        public void should_create_dark_roast_with_sugar()
        {
            var darkRoast = new DarkRoast();
            var darkRoastWithSugar = new DarkRoastWithSugar(darkRoast);

            var totalAmount = darkRoastWithSugar.Cost();

            Assert.Equal(15.00, totalAmount);
        }

        [Fact]
        public void should_create_dark_roast_with_milk()
        {
            var darkRoast = new DarkRoast();
            var darkRoastWithMilk = new DarkRoastWithMilk(darkRoast);

            var totalAmount = darkRoastWithMilk.Cost();

            Assert.Equal(15.00, totalAmount);
        }
    }
}