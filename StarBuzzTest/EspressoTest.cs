using StarBuzz;
using Xunit;

namespace StarBuzzTest
{
    public class EspressoTest
    {
        [Fact]
        public void should_create_espresso_with_milk_sugar()
        {
            var espresso = new Espresso("espresso");
            espresso.Add(new Sugar());
            espresso.Add(new Milk());

            var totalAmount = espresso.Cost();

            Assert.Equal(20.00, totalAmount);
        }

        [Fact]
        public void should_create_espresso_with_sugar()
        {
            var espresso = new Espresso("espresso");
            espresso.Add(new Sugar());

            var totalAmount = espresso.Cost();

            Assert.Equal(15.00, totalAmount);
        }

        [Fact]
        public void should_create_espresso_with_milk()
        {
            var espresso = new Espresso("espresso");
            espresso.Add(new Milk());

            var totalAmount = espresso.Cost();

            Assert.Equal(15.00, totalAmount);
        }
    }

}