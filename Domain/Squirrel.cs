namespace Z00_Task.Domain
{
    internal class Squirrel : AnimalBase
    {
        public Squirrel(string name) : base(name)
        {
            Species = "Squirrel";
            IsPredator = false;
        }
    }
}
