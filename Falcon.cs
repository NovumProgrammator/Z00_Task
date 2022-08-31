namespace Z00_Task
{
    internal class Falcon : Animal
    {
        public Falcon(string name) : base(name)
        {
            Class = AnimalClass.Bird.ToString();
            Species = "Falcon";
            IsPredator = true;
        }
    }
}
