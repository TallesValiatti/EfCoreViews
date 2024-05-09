using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreViews.Models.Configurations;

public class AuthorConfiguration :  IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Name)
            .IsRequired();

        builder.HasData(new List<Author>
        {
            new()
            {
                Id = Guid.Parse("92338F02-F3A5-4C82-AC9F-F9DC1A8D7256"),
                Name = "J. R. R. Tolkien"
            },
            new()
            {
                Id = Guid.Parse("D7890984-FC4E-4AFA-8FC4-530F4C684A26"),
                Name = "James Carroll"
            }
        });
    }
}