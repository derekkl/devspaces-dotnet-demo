namespace NorthwindApp.Models;

public class Customer
{
    public string Id { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string? ContactName { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
