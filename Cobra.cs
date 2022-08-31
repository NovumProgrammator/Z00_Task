namespace Z00_Task
{
    internal class Cobra : AnimalBase
    {
        public Cobra(string name) : base(name)
        {
            Species = "Cobra";
            IsPredator = true;
        }
    }
}
