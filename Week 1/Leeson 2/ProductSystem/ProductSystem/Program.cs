
var book = new BookProduct
{
    Id = 1,
    Name = "Clean Code",
    Price = 20,
    Type = ProductTypeEnum.Book,
    Author = "Robert C. Martin",
    PageCount = 464
};

var clothing = new ClothingProduct
{
    Id = 2,
    Name = "Hoodie",
    Price = 30,
    Type = ProductTypeEnum.Clothing,
    Size = "M",
    Material = "Cotton"
};

var electronics = new ElectronicsProduct
{
    Id = 3,
    Name = "Phone",
    Price = 500,
    Type = ProductTypeEnum.Electronics,
    Voltage = 220,
    WarrantyMonths = 12
};

book.PrintInfo();
clothing.PrintInfo();
electronics.PrintInfo();

