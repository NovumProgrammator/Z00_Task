namespace Z00_Task.Domain
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
