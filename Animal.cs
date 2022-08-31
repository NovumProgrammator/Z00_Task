namespace Z00_Task
{
    internal abstract class AnimalBase
    {
        public static List<AnimalBase> animals = new List<AnimalBase>();
        public string Name { get; set; }
        public string Species { get; set; }
        public string Class { get => GetType().Name.ToString(); }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public double Speed { get; set; }
        public bool IsPredator { get; set; }

        public AnimalBase(string name)
        {
            Name = name;
            animals.Add(this);
        }
    }
}
