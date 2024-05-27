using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ConcreteDogBuilder : DogBuilder
    {
        private Dog dog = new Dog();

        public override void SetName(string name)
        {
            dog.Name = name;
        }

        public override void SetBreed(string breed)
        {
            dog.Breed = breed;
        }

        public override void SetAge(int age)
        {
            dog.Age = age;
        }

        public override void AddToy(string toy)
        {
            if (dog.Toys == null)
            {
                dog.Toys = new List<string>();
            }
            dog.Toys.Add(toy);
        }

        public override Dog GetDog()
        {
            return dog;
        }
    }
}
