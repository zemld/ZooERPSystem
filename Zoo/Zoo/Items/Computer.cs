using Zoo.Abstractions;

namespace Zoo.Items;

public class Computer : IInventory
{
    public string ItemName { get; set; }
    public int Number { get; set; }

    public Computer(string name, int number)
    {
        ItemName = name;
        Number = number;
    }
}