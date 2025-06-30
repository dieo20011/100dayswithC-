namespace Animal_Mnagement {
    interface IAnimal {
        string Name { get; set; }
        int Age { get; set; }
        GenderTypeEnum.GenderType Gender { get; set; }
        void MakeSound();
    }

    class Animal : IAnimal {
        public string Name { get; set; }
        public int Age { get; set; }
        public GenderTypeEnum.GenderType Gender { get; set; }
        
        public virtual void MakeSound() {
            Console.WriteLine("Some sound");
        }
    }

    class Dog : Animal {
        public override void MakeSound() {
            Console.WriteLine("Woof");
        }
    }

    class Cat: Animal {
        public override void MakeSound() {
            Console.WriteLine("Meow");
        }
    }

    class Duck : Animal {
        public override void MakeSound() {
            Console.WriteLine("Quack");
        }
    }
}