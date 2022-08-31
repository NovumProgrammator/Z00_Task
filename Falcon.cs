namespace Z00_Task
{
    internal class Falcon : AnimalBase
    {
        public Falcon(string name) : base(name)
        {
            Species = "Falcon";
            IsPredator = true;
        }
    }
}
