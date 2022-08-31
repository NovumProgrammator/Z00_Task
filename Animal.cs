namespace Z00_Task
{
    internal static class Animal
    {
        enum AnimalClass
        {
            Mammal,
            Bird,
            Reptile,
            Amphibian,
            Insect
        }
        public static string Class { get; set; }
        public static void GetSome()
        {
            Class = AnimalClass.Amphibian.ToString();
            Console.WriteLine(Class);
        }
    }
}
