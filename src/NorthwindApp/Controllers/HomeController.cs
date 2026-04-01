using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindApp.Data;

namespace NorthwindApp.Controllers;

public class HomeController(NorthwindContext db) : Controller
{
    public async Task<IActionResult> Index()
    {
        ViewBag.ProductCount  = await db.Products.CountAsync();
        ViewBag.CategoryCount = await db.Categories.CountAsync();
        ViewBag.CustomerCount = await db.Customers.CountAsync();
        ViewBag.OrderCount    = await db.Orders.CountAsync();
        ViewBag.PendingOrders = await db.Orders.CountAsync(o => o.ShippedDate == null);
        return View();
    }
}
