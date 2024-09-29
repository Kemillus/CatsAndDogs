using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndDogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cats cat = new Cats("Mona",10,"British");
            Dogs dog = new Dogs("Ben",10,"Chihua-hua");
            Person person = new Person("Lexa");
            person.Animals.Add(dog);
            person.Animals.Add(cat);
            dog.Owned();
            cat.Owned();
            Console.WriteLine(person);
            Console.ReadKey();
        }
    }
}
