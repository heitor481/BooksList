using BooksList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksList.Infra.Map;

public class BooksMap : IEntityTypeConfiguration<Books>
{
    public void Configure(EntityTypeBuilder<Books> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(300).IsRequired();
        builder.Property(x => x.DateLaunched).IsRequired();
        builder.HasOne<Authors>(x => x.Author).WithMany(x => x.Books)
            .HasForeignKey(x => x.AuthorId).OnDelete(DeleteBehavior.Cascade);
    }
}