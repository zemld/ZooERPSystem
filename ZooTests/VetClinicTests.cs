using Zoo;
using Zoo.Animals;

namespace ZooTests
{
    [TestFixture]
    public class VetClinicTests
    {
        [Test]
        public void IsAnimalCanBeInZoo_WhenAnimalIsHealthy_ReturnsTrue()
        {
            var vetClinic = new VetClinic();
            var tiger = new Tiger(5, true, "Шерхан");
            
            var result = vetClinic.IsAnimalCanBeInZoo(tiger);
            
            Assert.Equals(result, true);
        }

        [Test]
        public void IsAnimalCanBeInZoo_WhenAnimalIsNotHealthy_ReturnsFalse()
        {
            var vetClinic = new VetClinic();
            var rabbit = new Rabbit(2, false, "Бакс", 8);
            
            var result = vetClinic.IsAnimalCanBeInZoo(rabbit);
            
            Assert.Equals(result, false);
        }
    }
}