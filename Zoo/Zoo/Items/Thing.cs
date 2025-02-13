using Zoo.Abstractions;

namespace Zoo.Items;

public class Thing : IInventory
{
    public string ItemName { get; set; }
    public int Number { get; set; }

    public Thing(string name, int number)
    {
        ItemName = name;
        Number = number;
    }
}