using Microsoft.EntityFrameworkCore;
using UdemyEFCore.CodeFirst;
using UdemyEFCore.CodeFirst.DAL;

Initializer.Build(); // build metodu ile appsettings json formatı okunacak hale geliyor.

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(products => {
        Console.WriteLine($"{p.Name}");
    });
}