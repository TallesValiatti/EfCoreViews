namespace EfCoreViews.Models;

public class AuthorBookCount
{
    public Guid Id { get; set; }
    public string Author { get; set; } = default!;
    public int BookCount { get; set; } = default!;
}