using Zoo;
using Zoo.Animals;

namespace ZooTests
{
    public class ZooTests
    {
        [Fact]
        public void AddAnimal_AddsAnimalToZoo_WhenAnimalIsHealthy()
        {
            var clinic = new VetClinic();
            var zoo = new Zoo.Zoo(clinic);
            var monkey = new Monkey(5, true, "Чичи", 7);

            zoo.AddAnimal(monkey);

            Assert.Single(zoo.Animals);
            Assert.Equal(monkey, zoo.Animals[0]);
        }

        [Fact]
        public void AddAnimal_DoesNotAddAnimalToZoo_WhenAnimalIsNotHealthy()
        {
            var clinic = new VetClinic();
            var zoo = new Zoo.Zoo(clinic);
            var wolf = new Wolf(8, false, "Серый");

            zoo.AddAnimal(wolf);

            Assert.Empty(zoo.Animals);
        }

        [Fact]
        public void GetAmountOfFoodForAnimals_ReturnsCorrectSum()
        {
            var clinic = new VetClinic();
            var zoo = new Zoo.Zoo(clinic);
            zoo.AddAnimal(new Monkey(5, true, "Чичи", 7));
            zoo.AddAnimal(new Tiger(10, true, "Шерхан"));

            var totalFood = zoo.GetAmountOfFoodForAnimals();

            Assert.Equal(15, totalFood);
        }

        [Fact]
        public void GetAnimalsForContactZoo_ReturnsHerbivoresWithHighKindness()
        {
            var clinic = new VetClinic();
            var zoo = new Zoo.Zoo(clinic);
            var kindMonkey = new Monkey(5, true, "Чичи", 7);
            var unkindRabbit = new Rabbit(3, true, "Пушистик", 2);
            var tiger = new Tiger(10, true, "Шерхан");
            zoo.AddAnimal(kindMonkey);
            zoo.AddAnimal(unkindRabbit);
            zoo.AddAnimal(tiger);

            var contactZooAnimals = zoo.GetAnimalsForContactZoo();

            Assert.Single(contactZooAnimals);
            Assert.Equal(kindMonkey, contactZooAnimals[0]);
        }
    }
}