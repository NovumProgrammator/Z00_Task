namespace Z00_Task.Domain;

internal class InMemoryAnimalStorage
{
    private readonly List<AnimalBase> _animals = new List<AnimalBase>();

    public void AddAnimal(AnimalBase animalBase)
    {
        _animals.Add(animalBase);
    }

    public IEnumerable<AnimalBase> GetAnimalsList() => _animals;

    /// <summary>
    /// Search animal with given name.
    /// </summary>
    /// <param name="name">name to find</param>
    /// <param name="foundedAnimal">founded animal (if found)</param>
    /// <returns>true, if animal with such name found, otherwise false</returns>
    public bool TryFindAnimal(string name, out AnimalBase foundedAnimal)
    {
        foundedAnimal = _animals.FirstOrDefault(x => string.Equals(name, x.Name, StringComparison.InvariantCultureIgnoreCase));
        return foundedAnimal != null;
    }
}