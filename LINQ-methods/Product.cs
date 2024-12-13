public class Product
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool InStock { get; set; }
    public string Category { get; set; }
    public string Brand { get; set; }
    public DateTime ReleaseDate { get; set; }

    public Product(int id, string name, decimal price, bool inStock, string category, string brand, DateTime releaseDate)
    {
        Id = id;
        Name = name;
        Price = price;
        InStock = inStock;
        Category = category;
        Brand = brand;
        ReleaseDate = releaseDate;
    }
}