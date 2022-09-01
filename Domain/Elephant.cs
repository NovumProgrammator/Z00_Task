namespace Z00_Task.Domain
{
    internal class Elephant : AnimalBase
    {
        public Elephant() { }
        public Elephant(string name) : base(name)
        {
            Class = "Mammal";
            IsPredator = false;
        }
    }
}
