using BooksList.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksList.Infra;

public class BooksListDbContext : DbContext
{
    public DbSet<Books> Books { get; set; }
    public DbSet<Authors> Authors { get; set; }

    public BooksListDbContext(DbContextOptions<BooksListDbContext> options) : base(options) 
    {
        
    }
}