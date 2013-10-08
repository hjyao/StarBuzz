using StarBuzz;
using Xunit;

namespace StarBuzzTest
{
    public class EspressoTest
    {
        [Fact]
        public void should_compute_espresso_with_milk_sugar()
        {
            var espresso = new Espresso(true, true);

            var totalAmount = espresso.Cost();

            Assert.Equal(20.00, totalAmount);
        }

        [Fact]
        public void should_compute_espresso_with_sugar()
        {
            var espresso = new Espresso(false, true);

            var totalAmount = espresso.Cost();

            Assert.Equal(15.00, totalAmount);
        }

        [Fact]
        public void should_compute_espresso_with_milk()
        {
            var espresso = new Espresso(true, false);

            var totalAmount = espresso.Cost();

            Assert.Equal(15.00, totalAmount);
        }
    }
}