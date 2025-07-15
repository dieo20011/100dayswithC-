using ProductSystem;

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Book
            {
                Id = 1,
                Name = "Clean Code",
                Price = 20.00m,
                Type = EProductType.Book,
                Author = "Robert C. Martin",
                PageCount = 464
            },
            new Clothing
            {
                Id = 2,
                Name = "Hoodie",
                Price = 30.00m,
                Type = EProductType.Clothing,
                Size = "M",
                Material = "Cotton"
            },
            new ElectronicsProduct
            {
                Id = 3,
                Name = "Phone",
                Price = 500.00m,
                Type = EProductType.Electronics,
                Voltage = 220,
                WarrantyMonths = 12
            }
        };

        foreach (var product in products)
        {
            product.PrintInfo();
        }
    }
}