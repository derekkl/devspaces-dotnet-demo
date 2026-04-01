namespace NorthwindApp.Models;

public class Order
{
    public int Id { get; set; }
    public string CustomerId { get; set; } = string.Empty;
    public Customer? Customer { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public string? ShipCity { get; set; }
    public string? ShipCountry { get; set; }
    public decimal Freight { get; set; }
}
