using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class DogBuilder
    {
        public abstract void SetName(string name);
        public abstract void SetBreed(string breed);
        public abstract void SetAge(int age);
        public abstract void AddToy(string toy);
        public abstract Dog GetDog();
    }

}
