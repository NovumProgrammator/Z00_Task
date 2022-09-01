namespace Z00_Task.Domain
{
    internal class Cobra : AnimalBase
    {
        public Cobra() { }
        public Cobra(string name) : base(name)
        {
            Class = "Reptile";
            IsPredator = true;
        }
    }
}
