using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsManagement
{

    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        string Sound { get; set; }
        EGender Gender { get; set; }
        void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }

    public class Animals : IAnimal
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public required EGender Gender { get; set; }
        public required string Sound { get; set; }

        public void MakeSound(string Sound)
        {
            Console.WriteLine(Sound);
        }
    }

    public class Dog : Animals
    {
       
    }

    public class Cat : Animals
    {

    }

    public class Duck : Animals
    {

    }
}
