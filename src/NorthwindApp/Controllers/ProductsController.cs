using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindApp.Data;

namespace NorthwindApp.Controllers;

public class ProductsController(NorthwindContext db) : Controller
{
    public async Task<IActionResult> Index(int? categoryId)
    {
        var query = db.Products.Include(p => p.Category).AsQueryable();

        if (categoryId.HasValue)
            query = query.Where(p => p.CategoryId == categoryId.Value);

        ViewBag.Categories  = await db.Categories.ToListAsync();
        ViewBag.CategoryId  = categoryId;

        return View(await query.OrderBy(p => p.Name).ToListAsync());
    }
}
