namespace Z00_Task
{
    internal abstract class Animal
    {
        public static List<Animal> animals = new List<Animal>();
        public enum AnimalClass
        {
            Mammal,
            Bird,
            Reptile,
            Amphibian,
            Insect
        }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Class { get; set; }
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
