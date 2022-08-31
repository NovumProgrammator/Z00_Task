namespace Z00_Task
{
    internal abstract class Animal
    {
        public static List<Animal> animals = new List<Animal>();
        public string Name { get; set; }
        public string Species { get; set; }
        public string Class { get => this.GetType().Name; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public double Speed { get; set; }
        public bool IsPredator { get; set; }

        public Animal(string name)
        {
            Name = name;
            animals.Add(this);
        }
    }
}
