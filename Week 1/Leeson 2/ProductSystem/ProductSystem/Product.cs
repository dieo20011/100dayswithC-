public enum ProductTypeEnum {
    Book,
    Clothing,
    Electronics,
}

public class Product {
    public int Id { get; set; }
    public string Name { get; set; }
    public ProductTypeEnum Type { get; set; }

    public decimal Price { get; set; }
    public ProductTypeEnum ProductType { get; set;}

    public virtual void PrintInfo() {
        Console.WriteLine($"Product ID: {Id}, Name: {Name}, Type: {Type}");
    }
}

public class BookProduct : Product {
    public string Author { get; set; }
    public int PageCount { get; set; }

    public override void PrintInfo() {
        Console.WriteLine($"Book: {Name}, Author: {Author}, Price: ${Price}");
    }
}

public class ClothingProduct : Product {
    public string Size { get; set; }
    public string Material { get; set; }
    
    public override void PrintInfo() {
        Console.WriteLine($"Clothing: {Name}, Size: {Size}, Material: {Material}, Price: ${Price}");
    }
}

public class ElectronicsProduct : Product {
    public decimal Voltage { get; set; }
    public decimal WarrantyMonths { get; set; }

    public override void PrintInfo() {
        Console.WriteLine($"Electronics: {Name}, Voltage: {Voltage}V, Warranty: {WarrantyMonths} months, Price: ${Price}");
    }
}