namespace Animal_Mnagement {
    interface IAnimal {
        string Name { get; set; }
        int Age { get; set; }
        string Sound { get; set; }
        EGenderType Gender { get; set; }
        void MakeSound(string sound) {
            Console.WriteLine(sound);
        }
    }

    class Animal : IAnimal {
        public string Name { get; set; }
        public int Age { get; set; }
        public EGenderType Gender { get; set; }
        public string Sound { get; set; }
        public void MakeSound() {
            Console.WriteLine(Sound);
        }
        
    }

    class Dog : Animal {
        public void MakeSound(string sound) {
            Console.WriteLine(sound);
        }
    }

    class Cat: Animal {
        public void MakeSound(string sound) {
            Console.WriteLine(sound);
        }
    }

    class Duck : Animal {
        public void MakeSound(string sound) {
            Console.WriteLine(sound);
        }
    }
}