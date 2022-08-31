namespace Z00_Task
{
    internal class Zoo
    {
        private readonly List<AnimalBase> _animals = new List<AnimalBase>();

        public void AddAnimal(AnimalBase animalBase)
        {
            _animals.Add(animalBase);
        }

        public void GetAnimalsList()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine($"{animal.Species} - {animal.Name}");
            }
        }

        public void FindAnimal(string name)
        {
            if (_animals.Count > 0)
            {
                foreach (var animal in _animals)
                {
                    if (animal.Name == name)
                    {
                        Console.WriteLine($"{animal.Species} - {animal.Name}");
                    }
                    else
                    {
                        Console.WriteLine("There's no such animal name");
                    }
                }
            }

            Console.WriteLine("There're no animals in this Zoo");
        }
    }
}
