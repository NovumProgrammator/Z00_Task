namespace Z00_Task
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
