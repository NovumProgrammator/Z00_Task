namespace Z00_Task
{
    internal class Squirrel : Animal
    {
        public Squirrel(string name) : base(name)
        {
            Class = AnimalClass.Mammal.ToString();
            Species = "Squirrel";
            IsPredator = false;
        }
    }
}
