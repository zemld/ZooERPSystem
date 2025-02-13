using NUnit.Framework;
using Zoo.Animals;

namespace ZooTests
{
    [TestFixture]
    public class AnimalTests
    {
        [Test]
        public void Monkey_ToString_ReturnsCorrectDescription()
        {
            var monkey = new Monkey(3, true, "Чита", 5);

            var result = monkey.ToString();

            Assert.Equals("Обезьяна Чита. Здоров(а). В день нужно 3 еды. Уровень доброты 5.", result);
        }

        [Test]
        public void Rabbit_ToString_ReturnsCorrectDescription()
        {
            var rabbit = new Rabbit(2, false, "Бакс", 8);

            var result = rabbit.ToString();

            Assert.Equals("Кролик Бакс. Болен(-на). В день нужно 2 еды. Уровень доброты 8.", result);
        }

        [Test]
        public void Tiger_ToString_ReturnsCorrectDescription()
        {
            var tiger = new Tiger(5, true, "Шерхан");

            var result = tiger.ToString();

            Assert.Equals("Тигр Шерхан. Здоров(а). В день нужно 5 еды.", result);
        }

        [Test]
        public void Wolf_ToString_ReturnsCorrectDescription()
        {
            var wolf = new Wolf(4, false, "Серый");

            var result = wolf.ToString();

            Assert.Equals("Волк Серый. Болен(-на). В день нужно 4 еды.", result);
        }

        [Test]
        public void Animal_Properties_AreAssignedCorrectly()
        {
            var monkey = new Monkey(3, true, "Чита", 5);
            var rabbit = new Rabbit(2, false, "Бакс", 8);
            var tiger = new Tiger(5, true, "Шерхан");
            var wolf = new Wolf(4, false, "Серый");

            Assert.Equals("Чита", monkey.Name);
            Assert.Equals(3, monkey.Food);
            Assert.Equals(true, monkey.IsHealthy);
            Assert.Equals(5, monkey.Kindness);

            Assert.Equals("Бакс", rabbit.Name);
            Assert.Equals(2, rabbit.Food);
            Assert.Equals(false, rabbit.IsHealthy);
            Assert.Equals(8, rabbit.Kindness);

            Assert.Equals("Шерхан", tiger.Name);
            Assert.Equals(5, tiger.Food);
            Assert.Equals(true, tiger.IsHealthy);

            Assert.Equals("Серый", wolf.Name);
            Assert.Equals(4, wolf.Food);
            Assert.Equals(false, wolf.IsHealthy);
        }
    }
}