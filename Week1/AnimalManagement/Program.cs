using AnimalManagement;

namespace Animal_Mnagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog { Name = "Lu", Age = 3, Gender = EGender.Male, Sound = "Woof 2" });
            animals.Add(new Cat { Name = "Meo", Age = 2, Gender = EGender.Female, Sound = "Meow 2" });
            animals.Add(new Duck { Name = "Vit", Age = 1, Gender = EGender.Male, Sound = "Quack 2" });

            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}, Gender: {animal.Gender}");
                animal.MakeSound(animal.Sound);
            }
        }
    }
}
