namespace Z00_Task
{
    internal class AnimalFactory
    {
        public AnimalBase Create(AnimalBase animal, string name)
        {
            switch (animal.Species.ToLower())
            {
                case "cobra":
                    return new Cobra(name);
                case "elephant":
                    return new Elephant(name);
                case "falcon":
                    return new Falcon(name);
                case "squirrel":
                    return new Squirrel(name);
                default:
                    throw new Exception("Choose animal species");
                    break;
            }
        }
    }
}
