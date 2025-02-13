namespace Zoo.Animals;

public abstract class Predator : Animal
{
    protected Predator(int food, bool isHealthy, string name) : base(food, isHealthy, name)
    {
    }
}