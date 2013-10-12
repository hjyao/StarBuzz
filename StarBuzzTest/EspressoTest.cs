using StarBuzz;
using Xunit;

namespace StarBuzzTest
{
    public class EspressoTest
    {
        [Fact]
        public void should_compute_espresso_with_milk_sugar()
        {
            var espresso = Espresso.CreateEspresso(true, true);

            var totalAmount = espresso.Cost();

            Assert.Equal(20.00, totalAmount);
        }

        [Fact]
        public void should_compute_espresso_with_sugar()
        {
            var espresso = Espresso.CreateEspresso(false, true);

            var totalAmount = espresso.Cost();

            Assert.Equal(15.00, totalAmount);
        }

        [Fact]
        public void should_compute_espresso_with_milk()
        {
            var espresso = Espresso.CreateEspresso(true, false);

            var totalAmount = espresso.Cost();

            Assert.Equal(15.00, totalAmount);
        }
    }
}