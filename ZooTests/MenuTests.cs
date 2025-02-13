using Zoo;

namespace ZooTests
{
    public class MenuOptionTests
    {
        [Fact]
        public void MenuOption_Constructor_SetsMessageCorrectly()
        {
            var message = "Test Option";

            var option = new MenuOption(message);

            Assert.Equal(message, option.Message);
        }
    }

    public class MenuTests
    {
        [Fact]
        public void AddOption_AddsOptionToMenu()
        {
            var menu = new Menu();
            var option = new MenuOption("Option 1");

            menu.AddOption(option);

            var optionsField = typeof(Menu).GetField("Options", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var options = (List<MenuOption>)optionsField.GetValue(menu);
            
            Assert.Single(options);
            Assert.Equal(option, options[0]);
        }

        [Fact]
        public void ShowMenu_DisplaysMenuOptionsWithCorrectHighlight()
        {
            var menu = new Menu();
            menu.AddOption(new MenuOption("Option 1"));
            menu.AddOption(new MenuOption("Option 2"));
            menu.AddOption(new MenuOption("Option 3"));

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var showMenuMethod = typeof(Menu).GetMethod("ShowMenu", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            showMenuMethod?.Invoke(menu, new object[] { 1 });

            var actualOutput = stringWriter.ToString();
            Assert.Contains("1. Option 1", actualOutput);
            Assert.Contains("2. Option 2", actualOutput);
            Assert.Contains("3. Option 3", actualOutput);
        }
    }
}