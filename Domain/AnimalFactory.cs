namespace Z00_Task.Domain
{
    internal static class AnimalFactory
    {
        public static AnimalBase Create(AnimalBase animalBase, string name)
        {
            switch (animalBase.Species)
            {
                case "Cobra":
                    return new Cobra(name);
                case "Elephant":
                    return new Elephant(name);
                case "Falcon":
                    return new Falcon(name);
                case "Squirrel":
                    return new Squirrel(name);
                default:
                    Console.WriteLine("Choose animal species");
                    return null;
                    break;
            }
        }
    }
}
