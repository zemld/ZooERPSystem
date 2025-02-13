namespace Zoo.Animals;

public abstract class Herbo : Animal
{
    public int Kindness { get; set; }
    protected Herbo(int food, bool isHealthy, string name, int kindness) : base(food, isHealthy, name)
    {
        Kindness = kindness;
    }

    public override string ToString()
    {
        return base.ToString() + $" Уровень доброты {Kindness}.";
    }
}