using Zoo.Animals;

namespace ZooTests
{
    public class AnimalsTests
    {
        [Fact]
        public void Monkey_ToString_ReturnsCorrectString()
        {
            var monkey = new Monkey(5, true, "Чичи", 7);

            var result = monkey.ToString();

            Assert.Equal("Обезьяна Чичи. Здоров(а). В день нужно 5 еды. Уровень доброты 7.", result);
        }

        [Fact]
        public void Rabbit_ToString_ReturnsCorrectString()
        {
            var rabbit = new Rabbit(3, false, "Пушистик", 5);

            var result = rabbit.ToString();

            Assert.Equal("Кролик Пушистик. Болен(-на). В день нужно 3 еды. Уровень доброты 5.", result);
        }

        [Fact]
        public void Tiger_ToString_ReturnsCorrectString()
        {
            var tiger = new Tiger(10, true, "Шерхан");

            var result = tiger.ToString();

            Assert.Equal("Тигр Шерхан. Здоров(а). В день нужно 10 еды.", result);
        }

        [Fact]
        public void Wolf_ToString_ReturnsCorrectString()
        {
            var wolf = new Wolf(8, false, "Серый");

            var result = wolf.ToString();

            Assert.Equal("Волк Серый. Болен(-на). В день нужно 8 еды.", result);
        }
    }
}