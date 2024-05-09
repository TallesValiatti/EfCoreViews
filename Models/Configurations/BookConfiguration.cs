using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreViews.Models.Configurations;

public class BookConfiguration :  IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Name)
            .IsRequired();

        builder.HasOne(x => x.Author)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.AuthorId);
        
        builder.HasData(new List<Book>
        {
            new()
            {
                Id = Guid.Parse("2AE6873C-31BC-48DE-85F9-C63289A312B3"),
                AuthorId = Guid.Parse("92338F02-F3A5-4C82-AC9F-F9DC1A8D7256"),
                Name = "The lord of the rings"
            },
            new()
            {
                Id = Guid.Parse("72C6EC9B-3964-4272-BED5-4D460020B79B"),
                AuthorId = Guid.Parse("92338F02-F3A5-4C82-AC9F-F9DC1A8D7256"),
                Name = "The hobbit"
            }
        });
    }
}