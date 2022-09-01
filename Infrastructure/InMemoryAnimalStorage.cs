using Z00_Task.Domain;

namespace Z00_Task.Infrastructure;

internal class InMemoryAnimalStorage : IAnimalStorage
{
    private readonly List<AnimalBase> _animals = new List<AnimalBase>();

    public void AddAnimal(AnimalBase animalBase)
    {
        _animals.Add(animalBase);
    }

    public IEnumerable<AnimalBase> PrintAnimals() => _animals;

    /// <summary>
    /// Search animal with given name.
    /// </summary>
    /// <param name="name">name to find</param>
    /// <param name="foundedAnimal">founded animal (if found)</param>
    /// <returns>true, if animal with such name found, otherwise false</returns>
    public bool TryFindAnimal(string name, out AnimalBase? foundedAnimal)
    {
        foundedAnimal = _animals.FirstOrDefault(x => string.Equals(name, x.Name, StringComparison.InvariantCultureIgnoreCase));
        
        if (foundedAnimal != null)
            foundedAnimal.Name = name;

        return foundedAnimal != null;
    }
}