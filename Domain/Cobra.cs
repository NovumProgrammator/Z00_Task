namespace Z00_Task.Domain
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
