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
    Console.WriteLine(new string('=', 30));        // separator
    Console.WriteLine("What do you want to do?\n");

    for (int i = 0; i < actionVariants.Length; i++)
    {
        Console.WriteLine(actionVariants[i]);
    }
    Console.WriteLine();

    int.TryParse(Console.ReadLine(), out int actionChoice);

    Console.WriteLine(new string('-', 30));

    // First block -- choosing action
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
}

static void AddAnimalToZoo(List<AnimalBase> animals, Zoo zoo)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("What kind of animal do you want to add?\n");

    for (int i = 0; i < animals.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {animals[i].Species}");
    }
    Console.WriteLine(new string('-', 30)); // ------------ separator

    animalChoise:
    int.TryParse(Console.ReadLine(), out int animalChoise);

    if (animalChoise > 0 && animalChoise <= animals.Count)
    {
        Console.Write("\nInput Name: ");
        string animalName = Console.ReadLine();

        Console.Write("Choose a gender (0 - Unknown | 1 - Female | 2 - Male): ");
        uint.TryParse(Console.ReadLine(), out uint gender);
        if (gender > 2) gender = 0;

        Console.Write("Max Speed (m/s): ");
        double.TryParse(Console.ReadLine(), out double speed);

        Console.Write("Weight (gramm): ");
        double.TryParse(Console.ReadLine(), out double weight);

        switch (animalChoise)
        {
            case 1:
                zoo.AddAnimal(new Cobra(animalName) { AnimalGender = (Gender)gender, MaxSpeed = speed, Weight = weight});
                zoo.PrintAnimals();
                break;
            case 2:
                zoo.AddAnimal(new Elephant(animalName) { AnimalGender = (Gender)gender, MaxSpeed = speed, Weight = weight });
                break;
            case 3:
                zoo.AddAnimal(new Falcon(animalName) { AnimalGender = (Gender)gender, MaxSpeed = speed, Weight = weight});
                break;
            case 4:
                zoo.AddAnimal(new Squirrel(animalName) { AnimalGender = (Gender)gender, MaxSpeed = speed, Weight = weight });
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



