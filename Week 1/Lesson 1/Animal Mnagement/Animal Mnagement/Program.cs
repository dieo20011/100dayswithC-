namespace Animal_Mnagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Dog { Name = "Lu", Age = 3, Gender = EGenderType.Male, Sound = "Woof 2" });
            animals.Add(new Cat { Name = "Meo", Age = 2, Gender = EGenderType.Female, Sound = "Meow 2" });
            animals.Add(new Duck { Name = "Vit", Age = 1, Gender = EGenderType.Male, Sound = "Quack 2" });

            foreach (var animal in animals) {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}, Gender: {animal.Gender}");
                animal.MakeSound(animal.Sound);
            }
        }
    }
}
