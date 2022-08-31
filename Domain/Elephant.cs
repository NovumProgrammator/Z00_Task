namespace Z00_Task.Domain
{
    internal class Elephant : AnimalBase
    {
        public Elephant(string name) : base(name)
        {
            Species = "Elephant";
            IsPredator = false;
        }
    }
}
