namespace Z00_Task.Domain
{
    internal class Falcon : AnimalBase
    {
        public Falcon() { }
        public Falcon(string name) : base(name)
        {
            Class = "Bird";
            IsPredator = true;
        }
    }
}
