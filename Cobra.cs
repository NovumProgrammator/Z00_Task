namespace Z00_Task
{
    internal class Cobra : Animal
    {
        public Cobra(string name) : base(name)
        {
            Class = AnimalClass.Reptile.ToString();
            Species = "Cobra";
            IsPredator = true;
        }
    }
}
