using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndDogs
{
    internal class Human
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public List<Animal> Animals { get; protected set; } = new List<Animal>();

        public void RemoveAnimal(Animal animal)
        {

        }

        public string ShowAnimals(List<Animal> animals)
        {
            string ani = "";
            foreach (var item in animals)
            {
                ani += $"\n{item}";
            }
            return ani;
        }

        public override string ToString()
        {
            return $"{Name} {ShowAnimals(Animals)}";
        }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Human(string name)
        {
            Name = name;
        }
    }
}
