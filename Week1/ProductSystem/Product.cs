using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSystem
{
    // Base class
    public abstract class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public EProductType Type { get; set; }
        public decimal Price { get; set; }

        public abstract void PrintInfo();
    }

    public class Book : Product
    {
        public required string Author { get; set; }
        public int PageCount { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"Book: {Name}, Author: {Author}, Pages: {PageCount}, Price: {Price:F2}");
        }
    }

    public class Clothing : Product
    {
        public required string Size { get; set; }
        public required string? Material { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"Clothing: {Name}, Size: {Size}, Color: {Material ?? "N/A"}, Price: {Price:F2}");
        }
    }

    public class ElectronicsProduct : Product
    {
        public int Voltage { get; set; }
        public int WarrantyMonths { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Electronics: {Name}, Voltage: {Voltage}V, Warranty: {WarrantyMonths} months, Price: {Price:F2}");
        }
    }
}
