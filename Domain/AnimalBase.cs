namespace Z00_Task.Domain
{
    /// <summary>
    /// Base class for all animals.
    /// </summary>
    
    public enum Gender
    {
        Unknown,
        Female,
        Male
    }
    public abstract class AnimalBase
    {
        public string Name { get; set; }
        /// <summary>
        /// Kind of an animal (for example, milk feeding)
        /// </summary>
        public string Species { get => GetType().Name; }
        public string Class { get; protected set; } // automatically sets in the constructor
        public Gender AnimalGender { get; set; }
        public double Weight { get; set; }   // gramm
        public double MaxSpeed { get; set; } // m/s
        public bool IsPredator { get; protected set; }

        public AnimalBase(){ }
        public AnimalBase(string name)
        {
            Name = name;
        }
    }
}
