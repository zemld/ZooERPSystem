namespace Zoo.Animals;

public class Rabbit : Herbo
{
    public Rabbit(int food, bool isHealthy, string name, int kindness) : base(food, isHealthy, name, kindness)
    {
    }
    
    public override string ToString()
    {
        return "Кролик " + base.ToString();
    }
}