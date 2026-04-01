using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindApp.Data;

namespace NorthwindApp.Controllers;

public class CategoriesController(NorthwindContext db) : Controller
{
    public async Task<IActionResult> Index()
    {
        var categories = await db.Categories
            .Include(c => c.Products)
            .OrderBy(c => c.Name)
            .ToListAsync();

        return View(categories);
    }
}
