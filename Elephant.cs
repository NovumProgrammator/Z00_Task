namespace Z00_Task
{
    internal class Elephant : Animal
    {
        public Elephant(string name) : base(name)
        {
            Species = "Elephant";
            IsPredator = false;
        }
    }
}
