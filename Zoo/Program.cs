using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Zoo.Abstractions;
using Zoo.Animals;
using Zoo.Items;

namespace Zoo;

public static class Program
{
    public static void Main()
    {
        var serviceProvider = GetServiceProvider();
        Zoo zoo;
        try
        {
            zoo = serviceProvider.GetRequiredService<Zoo>();
        }
        catch (Exception e)
        {
            zoo = new Zoo(new VetClinic());
        }

        var mainMenu = CreateMainMenu();
        do
        {
            var choice = mainMenu.ShowAndGetChoice();
            MakeAction(choice, zoo);
            WaitForKeyTap();
        } while (IsRepeatNeeded());
    }
    
    private static ServiceProvider GetServiceProvider()
    {
        var serviceProvider = new ServiceCollection()
            .AddTransient<VetClinic>()
            .AddSingleton<Zoo>()
            .BuildServiceProvider();
        return serviceProvider;
    }

    private static void MakeAction(int choice, Zoo zoo)
    {
        switch (choice)
        {
            case 1:
                zoo.AddAnimal(ChooseAndCreateAnimal());
                break;
            case 2:
                int foodAmount = zoo.GetAmountOfFoodForAnimals();
                Console.WriteLine($"Животным необходимо {foodAmount} еды.");
                break;
            case 3:
                zoo.GetInfoAboutAnimals();
                break;
        }
    }

    private static bool IsRepeatNeeded()
    {
        Console.Clear();
        Console.Write("Если хотите еще раз совершить действия из меню, нажмите Y: ");
        ConsoleKey key = Console.ReadKey().Key;
        return key == ConsoleKey.Y;
    }
    
    private static Animal ChooseAndCreateAnimal()
    {
        var animalMenu = CreateAnimalsMenu();
        var choice = animalMenu.ShowAndGetChoice();
        Animal animal;
        var (food, isHealthy, name) = EnterAnimalInfo();
        int kindness;
        switch (choice)
        {
            case 1:
                kindness = EnterKindnessLevel();
                animal = new Monkey(food, isHealthy, name, kindness);
                break;
            case 2:
                kindness = EnterKindnessLevel();
                animal = new Rabbit(food, isHealthy, name, kindness);
                break;
            case 3:
                animal = new Tiger(food, isHealthy, name);
                break;
            case 4:
                animal = new Wolf(food, isHealthy, name);
                break;
            default:
                throw new ArgumentException("Wrong value of animal's choice.");
        }

        return animal;
    }

    private static (int, bool, string) EnterAnimalInfo()
    {
        Console.Write("Введите количество еды для животного: ");
        int food = 0;
        bool isRepeatNeeded = true;
        do
        {
            try
            {
                var foodAsString = Console.ReadLine();
                food = int.Parse(foodAsString);
                if (food < 0)
                {
                    throw new ArgumentException();
                }
                isRepeatNeeded = false;
            }
            catch (Exception)
            {
                Console.Write("Количество еды для животного - натуральное число.\nПопробуйте еще раз: ");
            }
        } while (isRepeatNeeded);
        
        
        Console.Write("Здорово ли животное? (Y если здорово): ");
        ConsoleKey answer = Console.ReadKey().Key;
        bool isHealthy = answer == ConsoleKey.Y;
        Console.WriteLine();
        
        Console.Write("Имя животного: ");
        string name = Console.ReadLine() ?? "001";
        return (food, isHealthy, name);
    }

    private static int EnterKindnessLevel()
    {
        Console.Write("Введите уровень доброты животного (от 1 до 10): ");
        int kindness = 0;
        bool isRepeatNeeded = true;
        do
        {
            try
            {
                var kindnessStr = Console.ReadLine();
                kindness = int.Parse(kindnessStr);
                if (kindness is < 0 or > 10)
                {
                    throw new ArgumentException();
                }
                isRepeatNeeded = false;
            }
            catch (Exception)
            {
                Console.Write("Доброта животного - натуральное число от 1 до 10.\nПопробуйте еще раз: ");
            }
        } while (isRepeatNeeded);

        return kindness;
    }
    
    private static Menu CreateMainMenu()
    {
        Menu menu = new Menu();
        menu.AddOption(new MenuOption("Добавить новое животное."));
        menu.AddOption(new MenuOption("Получить количество еды для животных."));
        menu.AddOption(new MenuOption("Получить информацию о животных для контактного зоопарка"));
        return menu;
    }

    private static Menu CreateAnimalsMenu()
    {
        Menu animalsMenu = new Menu();
        animalsMenu.AddOption(new MenuOption("Обезьяна."));
        animalsMenu.AddOption(new MenuOption("Кролик."));
        animalsMenu.AddOption(new MenuOption("Тигр."));
        animalsMenu.AddOption(new MenuOption("Волк."));
        return animalsMenu;
    }

    private static void WaitForKeyTap()
    {
        Console.WriteLine("Для продолжения нажмите любую кнопку.");
        Console.ReadKey();
    }
}