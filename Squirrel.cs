namespace Z00_Task
{
    internal class Squirrel : Animal
    {
        public Squirrel(string name) : base(name)
        {
            Species = "Squirrel";
            IsPredator = false;
        }
    }
}
