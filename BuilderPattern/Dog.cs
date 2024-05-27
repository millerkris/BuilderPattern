namespace BuilderPattern
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public List<string> Toys { get; set; }

        public override string ToString()
        {
            return $"Dog: Name={Name}, Breed={Breed}, Age={Age}, Toys={string.Join(", ", Toys)}";
        }
    }
}