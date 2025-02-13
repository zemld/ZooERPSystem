namespace Zoo.Animals;

public class Monkey : Herbo
{
    public Monkey(int food, bool isHealthy, string name, int kindness) : base(food, isHealthy, name, kindness)
    {
    }
    
    public override string ToString()
    {
        return "Обезьяна " + base.ToString();
    }
}