namespace Z00_Task
{
    internal class Cobra : Animal
    {
        public Cobra(string name) : base(name)
        {
            Species = "Cobra";
            IsPredator = true;
        }
    }
}
