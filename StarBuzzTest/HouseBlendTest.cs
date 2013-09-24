using StarBuzz;
using Xunit;

namespace StarBuzzTest
{
    public class HouseBlendTest
    {
        [Fact]
        public void should_create_house_blend_with_milk_sugar()
        {
            var houseBlend = new HouseBlend("houseBlend");
            houseBlend.Add(new Sugar());
            houseBlend.Add(new Milk());

            var totalAmount = houseBlend.Cost();

            Assert.Equal(20.00, totalAmount);
        }

        [Fact]
        public void should_create_house_blend_with_sugar()
        {
            var houseBlend = new HouseBlend("houseBlend");
            houseBlend.Add(new Sugar());

            var totalAmount = houseBlend.Cost();

            Assert.Equal(15.00, totalAmount);
        }

        [Fact]
        public void should_create_house_blend_with_milk()
        {
            var houseBlend = new HouseBlend("houseBlend");

            houseBlend.Add(new Milk());

            var totalAmount = houseBlend.Cost();

            Assert.Equal(15.00, totalAmount);
        }
    }

}