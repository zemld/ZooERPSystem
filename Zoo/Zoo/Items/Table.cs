using Zoo.Abstractions;

namespace Zoo.Items;

public class Table : IInventory
{
    public string ItemName { get; set; }
    public int Number { get; set; }

    public Table(string name, int number)
    {
        ItemName = name;
        Number = number;
    }
}