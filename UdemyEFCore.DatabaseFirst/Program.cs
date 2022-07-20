using Microsoft.EntityFrameworkCore;
using UdemyEFCore.DatabaseFirst.DAL;

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Name}");
    });


}