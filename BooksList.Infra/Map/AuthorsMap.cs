using BooksList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksList.Infra.Map;

public class AuthorsMap : IEntityTypeConfiguration<Authors>
{
    public void Configure(EntityTypeBuilder<Authors> builder)
    {
        throw new NotImplementedException();
    }
}