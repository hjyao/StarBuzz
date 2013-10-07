using StarBuzz;
using Xunit;

namespace StarBuzzTest
{
    public class EspressoTest
    {
        [Fact]
        public void should_create_espresso_with_milk_sugar()
        {
            var espresso = new Espresso();
            var espressoWithSugarAndMilk = new Milk(new Sugar(espresso));


            var totalAmount = espressoWithSugarAndMilk.Cost();

            Assert.Equal(20.00, totalAmount);
        }

        [Fact]
        public void should_create_espresso_with_sugar()
        {
            var espresso = new Espresso();
            var espressoWithSugar = new Sugar(espresso);

            var totalAmount = espressoWithSugar.Cost();

            Assert.Equal(15.00, totalAmount);
        }

        [Fact]
        public void should_create_espresso_with_milk()
        {
            var espresso = new Espresso();
            var espressoWithMilk = new Milk(espresso);


            var totalAmount = espressoWithMilk.Cost();

            Assert.Equal(15.00, totalAmount);
        }
    }
}