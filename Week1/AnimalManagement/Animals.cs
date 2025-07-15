using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagement
{
    interface Animals
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

    public class Animal : Animals
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Sound { get; set; } = string.Empty;
        public EGender Gender { get; set; }
        public void MakeSound(string Sound)
        {
            Console.WriteLine($"The animal makes a sound: {Sound}");
        }
    }

    public class Dog : Animal
    { 

    }

    public class Duck : Animal
    {

    }

    public class Cat : Animal
    {
    }

}
