using Z00_Task.Domain;
using Z00_Task.Infrastructure;

var animalSpecieses = new List<AnimalBase>()
{
    new Cobra(), new Elephant(), new Falcon(), new Squirrel()
};

var zoo = new Zoo(new InMemoryAnimalStorage());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Start");
Console.ForegroundColor = ConsoleColor.Yellow;

string[] actionVariants =
    {
        "1 - Add animal to Zoo",
        "2 - Print list of animals",
        "3 - Find animal by name"
    };

while (true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(new String('=', 30));
    Console.WriteLine("What do you want to do?\n");

    for (int i = 0; i < actionVariants.Length; i++)
    {
        Console.WriteLine(actionVariants[i]);
    }
    Console.WriteLine();

    int.TryParse(Console.ReadLine(), out int actionChoice);

    Console.WriteLine(new String('-', 30));

    switch (actionChoice)
    {
        case 1:
            AddAnimalToZoo(animalSpecieses, zoo);
            break;

        case 2:
            foreach (var item in zoo.PrintAnimals())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{item.Species} - {item.Name}");
            }
            break;

        case 3:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Input name: ");

            string name = Console.ReadLine();

            TryToFind(name, zoo);
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You should choose between 1 and {actionVariants.Length}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
    }

    static AnimalBase AddAnimalToZoo(List<AnimalBase> animals, Zoo zoo)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("What kind of animal do you want to add?\n");

        for (int i = 0; i < animals.Count; i++)
        {
            Console.WriteLine($"{i+1} - {animals[i].Species}");
        }
        Console.WriteLine(new String('-', 30));

        animalChoise:
        int.TryParse(Console.ReadLine(), out int animalChoise);

        if (animalChoise > 0 && animalChoise <= animals.Count)
        {
            Console.WriteLine("\nGive it name:");

            string animalName = Console.ReadLine();

            switch (animalChoise)
            {
                case 1:
                    zoo.AddAnimal(new Cobra(animalName));
                    break;
                case 2:
                    zoo.AddAnimal(new Elephant(animalName));
                    break;
                case 3:
                    zoo.AddAnimal(new Falcon(animalName));
                    break;
                case 4:
                    zoo.AddAnimal(new Squirrel(animalName));
                    break;
                default:
                    break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You should choose between 1 and {animals.Count}");
            Console.ForegroundColor = ConsoleColor.White;
            goto animalChoise;
        }

        return null;
    }

    static void TryToFind(string name, Zoo zoo)
    {
        bool found = zoo.TryFindAnimal(name, out AnimalBase? animal);

        if (found)
        {
            Console.WriteLine("Success:");
            Console.WriteLine($"{animal.Species} - {animal.Name}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not found");
        }
    }
}



