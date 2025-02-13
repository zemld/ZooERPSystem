using Zoo;

namespace ZooTests
{
    public class ProgramTests
    {
        [Fact]
        public void CreateMainMenu_ShouldContainThreeOptions()
        {
            var mainMenu = Program.CreateMainMenu();

            Assert.NotNull(mainMenu);
            Assert.Equal(3, mainMenu.Options.Count);
            Assert.Equal("Добавить новое животное.", mainMenu.Options[0].Message);
            Assert.Equal("Получить количество еды для животных.", mainMenu.Options[1].Message);
            Assert.Equal("Получить информацию о животных для контактного зоопарка", mainMenu.Options[2].Message);
        }

        [Fact]
        public void CreateAnimalsMenu_ShouldContainFourOptions()
        {
            var animalsMenu = Program.CreateAnimalsMenu();

            Assert.NotNull(animalsMenu);
            Assert.Equal(4, animalsMenu.Options.Count);
            Assert.Equal("Обезьяна.", animalsMenu.Options[0].Message);
            Assert.Equal("Кролик.", animalsMenu.Options[1].Message);
            Assert.Equal("Тигр.", animalsMenu.Options[2].Message);
            Assert.Equal("Волк.", animalsMenu.Options[3].Message);
        }
    }
}