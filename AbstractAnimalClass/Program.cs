namespace Animals
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }
    class Program
    {
        class Bear : Animal
        {
            public override string Name { get; set; }
            public string Species { get; set; }
            public Bear()
            {
                Name = string.Empty;
                Species = string.Empty;
            }
            public Bear(string name, string type)
            {
                Name = name;
                Species = type;
            }
            public override string Describe()
            {
                return "I am a " + Species + "\nMy name is " + Name;
            }

        }
        static void Main(string[] args)
        {
            Bear Boris = new Bear();
            Boris.Name = "Boris";
            Boris.Species = "Bear";
            Console.WriteLine(Boris.whatAmI());
            Console.WriteLine(Boris.Describe());
        }
    }
}
