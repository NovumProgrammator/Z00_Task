namespace Z00_Task
{
    /// <summary>
    /// Base class for all animals.
    /// </summary>
    internal abstract class AnimalBase
    {
        public static List<AnimalBase> animals = new List<AnimalBase>();
        public string Name { get; set; }
        /// <summary>
        /// Kind of an animal (for example, milk feeding)
        /// </summary>
        public string Species { get; set; }
        public string Class { get => this.GetType().Name; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public double Speed { get; set; }
        public bool IsPredator { get; protected set; }

        public AnimalBase(string name)
        {
            Name = name;
            animals.Add(this);
        }
    }
}
