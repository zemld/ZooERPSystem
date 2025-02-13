using Zoo;
using Zoo.Animals;

namespace ZooTests
{
    public class VetClinicTests
    {
        [Fact]
        public void IsAnimalCanBeInZoo_ReturnsTrue_WhenAnimalIsHealthy()
        {
            var clinic = new VetClinic();
            var tiger = new Tiger(10, true, "Шерхан");

            var result = clinic.IsAnimalCanBeInZoo(tiger);

            Assert.True(result);
        }

        [Fact]
        public void IsAnimalCanBeInZoo_ReturnsFalse_WhenAnimalIsNotHealthy()
        {
            var clinic = new VetClinic();
            var rabbit = new Rabbit(3, false, "Пушистик", 5);

            var result = clinic.IsAnimalCanBeInZoo(rabbit);

            Assert.False(result);
        }
    }
}