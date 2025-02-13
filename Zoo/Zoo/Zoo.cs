using Zoo.Abstractions;
using Zoo.Animals;

namespace Zoo;

public class Zoo
{
    public List<IInventory> Inventory { get; set; }
    
    public List<IAlive> Animals { get; set; }
    
    public VetClinic Clinic { get; set; }

    public Zoo(VetClinic clinic)
    {
        Clinic = clinic;
        Inventory = new List<IInventory>();
        Animals = new List<IAlive>();
    }

    public void AddAnimal(Animal animal)
    {
        if (Clinic.IsAnimalCanBeInZoo(animal))
        {
            Animals.Add(animal);
            Console.WriteLine("Животное добавлено в зоопарк.");
        }
        else
        {
            Console.WriteLine("Животное не может быть добавлено в зоопарк.");
        }
    }

    public int GetAmountOfFoodForAnimals()
    {
        return Animals.Sum(animal => animal.Food);
    }

    public List<IAlive>? GetAnimalsForContactZoo()
    {
        return Animals.OfType<Herbo>().Where(animal => animal.Kindness >= 5).Cast<IAlive>().ToList();
    }

    public void GetInfoAboutAnimals()
    {
        foreach (var animal in Animals)
        {
            Console.WriteLine(animal.ToString());
        }
    }
}