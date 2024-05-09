using EfCoreViews;
using Microsoft.EntityFrameworkCore;

await using var context = new AppDbContext();

var results = await context.Authors
    .Include(x => x.Books)
    .Select(x => new
    {
        Author = x,
        BookCount = x.Books.Count
    })
    .ToListAsync();

foreach (var result in results)
{
    Console.WriteLine($"Author: {result.Author.Name} -> Book count: {result.BookCount}");
}


