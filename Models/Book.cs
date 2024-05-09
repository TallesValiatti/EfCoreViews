namespace EfCoreViews.Models;

public class Book
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public Guid AuthorId { get; set; } = default!;
    public Author Author { get; set; } = default!;
}