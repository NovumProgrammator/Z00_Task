using Z00_Task.Infrastructure;

namespace Z00_Task.Domain
{
    internal class Zoo
    {
        private readonly IAnimalStorage _animalStorage;

        public Zoo (IAnimalStorage animalStorage)
        {
            _animalStorage = animalStorage;
        }

        public void AddAnimal(AnimalBase animal)
        {
            _animalStorage.AddAnimal(animal);
        }

        public IEnumerable<AnimalBase> PrintAnimals() => _animalStorage.PrintAnimals();

        public bool TryFindAnimal(string name, out AnimalBase? foundedAnimal)
        {
            return _animalStorage.TryFindAnimal(name, out foundedAnimal);
        }
    }
}
