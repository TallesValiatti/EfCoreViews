using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreViews.Models.Configurations;

public class AuthorBookCountConfigurationConfiguration :  IEntityTypeConfiguration<AuthorBookCount>
{
    public void Configure(EntityTypeBuilder<AuthorBookCount> builder)
    {
        builder.HasKey(e => e.Id);
        builder.ToView("AuthorBookCounting");
    }
}