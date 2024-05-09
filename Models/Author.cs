namespace EfCoreViews.Models;

public class Author
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public IList<Book> Books { get; set; } = new List<Book>();
}