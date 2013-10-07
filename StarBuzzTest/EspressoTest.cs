using StarBuzz;
using Xunit;

namespace StarBuzzTest
{
    public class EspressoTest
    {
        [Fact]
        public void should_compute_espresso_with_milk_sugar()
        {
            var espresso = new Espresso {Milk = true, Sugar = true};

            var totalAmount = espresso.Cost();

            Assert.Equal(20.00, totalAmount);
        }

        [Fact]
        public void should_compute_espresso_with_sugar()
        {
            var espresso = new Espresso {Sugar = true};

            var totalAmount = espresso.Cost();

            Assert.Equal(15.00, totalAmount);
        }

        [Fact]
        public void should_compute_espresso_with_milk()
        {
            var espresso = new Espresso {Milk = true};

            var totalAmount = espresso.Cost();

            Assert.Equal(15.00, totalAmount);
        }
    }
}