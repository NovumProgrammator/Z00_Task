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
            _animals.ForEach(x =>
            {
                Console.WriteLine($"{x.Species} - {x.Name}");
            });
        }

        public void FindAnimal(string name)
        {
            if (_animals.Count > 0)
            {
                foreach (AnimalBase animal in _animals)
                {
                    if (string.Equals(name, animal.Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        // todo: убрать зависимость от способа ввода и вывода из этого класса
                        Console.WriteLine($"{animal.Species} - {animal.Name}");
                    }
                    else
                    {
                        Console.WriteLine("There's no such animal name");
                    }
                }
            }
            // todo: возможная проблема безопасности - даем пользователю больше данных, чем нужно
            Console.WriteLine("There're no animals in this Zoo");
        }
    }
}
