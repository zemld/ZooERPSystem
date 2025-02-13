namespace Zoo.Animals;

public class Tiger : Predator
{
    public Tiger(int food, bool isHealthy, string name) : base(food, isHealthy, name)
    {
    }
    
    public override string ToString()
    {
        return "Тигр " + base.ToString();
    }
}