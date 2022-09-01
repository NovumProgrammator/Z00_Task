namespace Z00_Task.Domain
{
    /// <summary>
    /// Base class for all animals.
    /// </summary>
    public abstract class AnimalBase
    {
        public string Name { get; set; }
        /// <summary>
        /// Kind of an animal (for example, milk feeding)
        /// </summary>
        public string Species { get => GetType().Name; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public double Speed { get; set; }
        public bool IsPredator { get; protected set; }

        public AnimalBase() { }
        public AnimalBase(string name)
        {
            Name = name;
        }
    }
}
