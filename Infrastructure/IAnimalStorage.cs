using Z00_Task.Domain;

namespace Z00_Task.Infrastructure;

public interface IAnimalStorage
{
    public void AddAnimal(AnimalBase animalBase);
    public IEnumerable<AnimalBase> GetAnimalsList();
    public bool TryFindAnimal(string name, out AnimalBase? foundedAnimal);
}