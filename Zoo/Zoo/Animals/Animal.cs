using Zoo.Abstractions;

namespace Zoo.Animals;

public abstract class Animal : IAlive
{
    public bool IsHealthy { get; set; }
    public string Name { get; set; }
    public int Food { get; set; }

    protected Animal(int food, bool isHealthy, string name)
    {
        this.Food = food;
        this.IsHealthy = isHealthy;
        this.Name = name;
    }

    public override string ToString()
    {
        return $"{Name}. {(IsHealthy == true ? "Здоров(а)" : "Болен(-на)")}. В день нужно {Food} еды.";
    }
}