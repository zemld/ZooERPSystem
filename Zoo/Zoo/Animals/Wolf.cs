namespace Zoo.Animals;

public class Wolf : Predator
{
    public Wolf(int food, bool isHealthy, string name) : base(food, isHealthy, name)
    {
    }
    
    public override string ToString()
    {
        return "Волк " + base.ToString();
    }
}