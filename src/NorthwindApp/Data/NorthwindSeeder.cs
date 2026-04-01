using NorthwindApp.Models;

namespace NorthwindApp.Data;

public static class NorthwindSeeder
{
    public static void Seed(NorthwindContext context)
    {
        if (context.Categories.Any()) return;

        var categories = new[]
        {
            new Category { Name = "Beverages",    Description = "Soft drinks, coffees, teas, beers, and ales" },
            new Category { Name = "Condiments",   Description = "Sweet and savory sauces, relishes, spreads, and seasonings" },
            new Category { Name = "Confections",  Description = "Desserts, candies, and sweet breads" },
            new Category { Name = "Dairy Products", Description = "Cheeses" },
            new Category { Name = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal" },
            new Category { Name = "Meat/Poultry", Description = "Prepared meats" },
            new Category { Name = "Produce",      Description = "Dried fruit and bean curd" },
            new Category { Name = "Seafood",      Description = "Seaweed and fish" },
        };
        context.Categories.AddRange(categories);
        context.SaveChanges();

        var products = new[]
        {
            new Product { Name = "Chai",                CategoryId = 1, SupplierName = "Exotic Liquids",      UnitPrice = 18.00m,  UnitsInStock = 39 },
            new Product { Name = "Chang",               CategoryId = 1, SupplierName = "Exotic Liquids",      UnitPrice = 19.00m,  UnitsInStock = 17 },
            new Product { Name = "Aniseed Syrup",       CategoryId = 2, SupplierName = "Exotic Liquids",      UnitPrice = 10.00m,  UnitsInStock = 13 },
            new Product { Name = "Chef Anton's Cajun Seasoning", CategoryId = 2, SupplierName = "New Orleans Cajun Delights", UnitPrice = 22.00m, UnitsInStock = 53 },
            new Product { Name = "Pavlova",             CategoryId = 3, SupplierName = "Pavlova Ltd.",         UnitPrice = 17.45m,  UnitsInStock = 29 },
            new Product { Name = "Alice Mutton",        CategoryId = 6, SupplierName = "Pavlova Ltd.",         UnitPrice = 39.00m,  UnitsInStock = 0,  Discontinued = true },
            new Product { Name = "Camembert Pierrot",   CategoryId = 4, SupplierName = "Gai Paturage",         UnitPrice = 34.00m,  UnitsInStock = 19 },
            new Product { Name = "Gorgonzola Telino",   CategoryId = 4, SupplierName = "Formaggi Fortini s.r.l.", UnitPrice = 12.50m, UnitsInStock = 0, Discontinued = true },
            new Product { Name = "Ikura",               CategoryId = 8, SupplierName = "Tokyo Traders",        UnitPrice = 31.00m,  UnitsInStock = 31 },
            new Product { Name = "Konbu",               CategoryId = 8, SupplierName = "Tokyo Traders",        UnitPrice = 6.00m,   UnitsInStock = 24 },
            new Product { Name = "Tofu",                CategoryId = 7, SupplierName = "Tokyo Traders",        UnitPrice = 23.25m,  UnitsInStock = 35 },
            new Product { Name = "Singaporean Hokkien Fried Mee", CategoryId = 5, SupplierName = "Leka Trading", UnitPrice = 14.00m, UnitsInStock = 26, Discontinued = true },
            new Product { Name = "Tunnbröd",            CategoryId = 5, SupplierName = "PB Knäckebröd AB",     UnitPrice = 9.00m,   UnitsInStock = 61 },
            new Product { Name = "Guaraná Fantástica",  CategoryId = 1, SupplierName = "Refrescos Americanas LTDA", UnitPrice = 4.50m, UnitsInStock = 20, Discontinued = true },
            new Product { Name = "Mishi Kobe Niku",     CategoryId = 6, SupplierName = "Tokyo Traders",        UnitPrice = 97.00m,  UnitsInStock = 29, Discontinued = true },
            new Product { Name = "Uncle Bob's Organic Dried Pears", CategoryId = 7, SupplierName = "Grandma Kelly's Homestead", UnitPrice = 30.00m, UnitsInStock = 15 },
            new Product { Name = "Northwoods Cranberry Sauce", CategoryId = 2, SupplierName = "Grandma Kelly's Homestead", UnitPrice = 40.00m, UnitsInStock = 6 },
            new Product { Name = "Mozzarella di Giovanni", CategoryId = 4, SupplierName = "Formaggi Fortini s.r.l.", UnitPrice = 34.80m, UnitsInStock = 14 },
            new Product { Name = "Röd Kaviar",          CategoryId = 8, SupplierName = "Svensk Sjöföda AB",    UnitPrice = 15.00m,  UnitsInStock = 101 },
            new Product { Name = "Flotemysost",         CategoryId = 4, SupplierName = "Norske Meierier",      UnitPrice = 21.50m,  UnitsInStock = 26 },
        };
        context.Products.AddRange(products);
        context.SaveChanges();

        var customers = new[]
        {
            new Customer { Id = "ALFKI", CompanyName = "Alfreds Futterkiste",       ContactName = "Maria Anders",    City = "Berlin",    Country = "Germany" },
            new Customer { Id = "ANATR", CompanyName = "Ana Trujillo Emparedados",  ContactName = "Ana Trujillo",    City = "México D.F.", Country = "Mexico" },
            new Customer { Id = "ANTON", CompanyName = "Antonio Moreno Taquería",   ContactName = "Antonio Moreno", City = "México D.F.", Country = "Mexico" },
            new Customer { Id = "AROUT", CompanyName = "Around the Horn",           ContactName = "Thomas Hardy",    City = "London",    Country = "UK" },
            new Customer { Id = "BERGS", CompanyName = "Berglunds snabbköp",        ContactName = "Christina Berglund", City = "Luleå", Country = "Sweden" },
            new Customer { Id = "BLAUS", CompanyName = "Blauer See Delikatessen",   ContactName = "Hanna Moos",      City = "Mannheim",  Country = "Germany" },
            new Customer { Id = "BLONP", CompanyName = "Blondesddsl père et fils",  ContactName = "Frédérique Citeaux", City = "Strasbourg", Country = "France" },
            new Customer { Id = "BOLID", CompanyName = "Bólido Comidas preparadas", ContactName = "Martín Sommer",   City = "Madrid",    Country = "Spain" },
            new Customer { Id = "BONAP", CompanyName = "Bon app'",                  ContactName = "Laurence Lebihan", City = "Marseille", Country = "France" },
            new Customer { Id = "BOTTM", CompanyName = "Bottom-Dollar Marketse",    ContactName = "Elizabeth Lincoln", City = "Tsawassen", Country = "Canada" },
        };
        context.Customers.AddRange(customers);
        context.SaveChanges();

        var orders = new[]
        {
            new Order { CustomerId = "ALFKI", OrderDate = new DateTime(2024, 1, 15), ShippedDate = new DateTime(2024, 1, 22), ShipCity = "Berlin",      ShipCountry = "Germany", Freight = 29.46m },
            new Order { CustomerId = "ANATR", OrderDate = new DateTime(2024, 1, 18), ShippedDate = new DateTime(2024, 1, 25), ShipCity = "México D.F.", ShipCountry = "Mexico",  Freight = 3.61m  },
            new Order { CustomerId = "AROUT", OrderDate = new DateTime(2024, 2,  2), ShippedDate = new DateTime(2024, 2,  9), ShipCity = "London",      ShipCountry = "UK",      Freight = 41.34m },
            new Order { CustomerId = "BERGS", OrderDate = new DateTime(2024, 2, 14), ShippedDate = null,                      ShipCity = "Luleå",       ShipCountry = "Sweden",  Freight = 12.75m },
            new Order { CustomerId = "BONAP", OrderDate = new DateTime(2024, 3,  1), ShippedDate = new DateTime(2024, 3,  8), ShipCity = "Marseille",   ShipCountry = "France",  Freight = 97.11m },
            new Order { CustomerId = "BOTTM", OrderDate = new DateTime(2024, 3, 10), ShippedDate = null,                      ShipCity = "Tsawassen",   ShipCountry = "Canada",  Freight = 55.28m },
            new Order { CustomerId = "BLONP", OrderDate = new DateTime(2024, 3, 22), ShippedDate = new DateTime(2024, 3, 29), ShipCity = "Strasbourg",  ShipCountry = "France",  Freight = 18.44m },
            new Order { CustomerId = "ALFKI", OrderDate = new DateTime(2024, 4,  5), ShippedDate = new DateTime(2024, 4, 12), ShipCity = "Berlin",      ShipCountry = "Germany", Freight = 67.20m },
            new Order { CustomerId = "ANTON", OrderDate = new DateTime(2024, 4, 18), ShippedDate = null,                      ShipCity = "México D.F.", ShipCountry = "Mexico",  Freight = 22.98m },
            new Order { CustomerId = "BLAUS", OrderDate = new DateTime(2024, 5,  3), ShippedDate = new DateTime(2024, 5, 10), ShipCity = "Mannheim",    ShipCountry = "Germany", Freight = 8.53m  },
        };
        context.Orders.AddRange(orders);
        context.SaveChanges();
    }
}
