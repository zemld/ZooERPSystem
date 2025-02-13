using Zoo.Animals;

namespace Zoo;

public class VetClinic
{
    public bool IsAnimalCanBeInZoo(Animal animal)
    {
        return animal.IsHealthy;
    }
}
