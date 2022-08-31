namespace Z00_Task
{
    internal class Falcon : Animal
    {
        public Falcon(string name) : base(name)
        {
            Species = "Falcon";
            IsPredator = true;
        }
    }
}
