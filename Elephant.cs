namespace Z00_Task
{
    internal class Elephant : Animal
    {
        public Elephant(string name) : base(name)
        {
            Class = AnimalClass.Mammal.ToString();
            Species = "Elephant";
            IsPredator = false;
        }
    }
}
