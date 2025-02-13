namespace Zoo;

public class Menu
{
    public List<MenuOption> Options { get; set; }

    public Menu()
    {
        Options = new List<MenuOption>();
    }
    
    public void AddOption(MenuOption option)
    {
        Options.Add(option);
    }
    
    public int ShowAndGetChoice()
    {
        Console.Clear();
        int chosenValue = 0;
        bool isValid = false;
        while (!isValid)
        {
            ShowMenu(chosenValue);
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    chosenValue = (chosenValue + Options.Count - 1) % Options.Count;
                    break;
                case ConsoleKey.DownArrow:
                    chosenValue = (chosenValue + 1) % Options.Count;
                    break;
                case ConsoleKey.Enter:
                    isValid = true;
                    break;
            }
            Console.Clear();
        }
        return chosenValue + 1;
    }

    private void ShowMenu(int chosenValue)
    {
        for (int i = 0; i != Options.Count; i++)
        {
            if (i == chosenValue)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                
                Console.Write($"{i + 1}. ");
                Console.WriteLine(Options[i].Message);
                
                Console.ResetColor();
                continue;
            }
            Console.Write($"{i + 1}. ");
            Console.WriteLine(Options[i].Message);
        }
    }
}