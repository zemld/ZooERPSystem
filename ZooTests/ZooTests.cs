using Zoo;
using Zoo.Animals;

namespace ZooTests
{
    [TestFixture]
    public class ZooTests
    {
        private VetClinic _vetClinic;
        private Zoo.Zoo _zoo;

        [SetUp]
        public void Setup()
        {
            _vetClinic = new VetClinic();
            _zoo = new Zoo.Zoo(_vetClinic);
        }

        [Test]
        public void AddAnimal_WhenAnimalIsHealthy_AddsAnimalToZoo()
        {
            var tiger = new Tiger(5, true, "Шерхан");

            _zoo.AddAnimal(tiger);

            Assert.That(_zoo.Animals, Does.Contain(tiger).And.Count.EqualTo(1), "Здоровое животное должно быть добавлено в зоопарк.");
        }

        [Test]
        public void AddAnimal_WhenAnimalIsNotHealthy_DoesNotAddAnimalToZoo()
        {
            var rabbit = new Rabbit(2, false, "Бакс", 8);

            _zoo.AddAnimal(rabbit);

            Assert.That(_zoo.Animals, Does.Not.Contain(rabbit), "Больное животное не должно быть добавлено в зоопарк.");
        }

        [Test]
        public void GetAmountOfFoodForAnimals_ReturnsCorrectSum()
        {
            var tiger = new Tiger(5, true, "Шерхан");
            var monkey = new Monkey(3, true, "Чита", 7);
            _zoo.AddAnimal(tiger);
            _zoo.AddAnimal(monkey);

            var totalFood = _zoo.GetAmountOfFoodForAnimals();

            Assert.That(totalFood, Is.EqualTo(8), "Общее количество еды должно быть равно сумме потребностей всех животных.");
        }

        [Test]
        public void GetAnimalsForContactZoo_ReturnsOnlyHerboWithKindnessGreaterThanOrEqualToFive()
        {
            var rabbit = new Rabbit(2, true, "Бакс", 8);
            var monkey = new Monkey(3, true, "Чита", 5);
            var tiger = new Tiger(5, true, "Шерхан");
            _zoo.AddAnimal(rabbit);
            _zoo.AddAnimal(monkey);
            _zoo.AddAnimal(tiger);

            var contactZooAnimals = _zoo.GetAnimalsForContactZoo();

            Assert.That(contactZooAnimals, Has.Count.EqualTo(2), "Должны быть выбраны только травоядные животные с уровнем доброты >= 5.");
            Assert.That(contactZooAnimals, Does.Contain(rabbit), "Кролик с добротой 8 должен быть выбран для контактного зоопарка.");
            Assert.That(contactZooAnimals, Does.Contain(monkey), "Обезьяна с добротой 5 должна быть выбрана для контактного зоопарка.");
        }
    }
}