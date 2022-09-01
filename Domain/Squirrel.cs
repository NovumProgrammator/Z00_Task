namespace Z00_Task.Domain
{
    internal class Squirrel : AnimalBase
    {
        public Squirrel() { }
        public Squirrel(string name) : base(name)
        {
            Class = "Mammal";
            IsPredator = false;
        }
    }
}
