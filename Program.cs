using EfCoreViews;
using Microsoft.EntityFrameworkCore;

await using var context = new AppDbContext();

var results = await context.AuthorBookCount.ToListAsync();

foreach (var result in results)
{
    Console.WriteLine($"Author: {result.Author} -> Book count: {result.BookCount}");
}


