using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        private readonly DogBuilder builder;

        public Director(DogBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructDog(string name, string breed, int age, string toy)
        {
            builder.SetName(name);
            builder.SetBreed(breed);
            builder.SetAge(age);
            builder.AddToy(toy);
        }

        public void AddToyToDog(string toy)
        {
            builder.AddToy(toy);
        }

        public void GetReadyDog()
        {
            Console.WriteLine(builder.GetDog().ToString());
        }
    }
}
