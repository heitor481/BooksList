using Microsoft.EntityFrameworkCore;

namespace BooksList.Infra;

public class BooksListDbContext : DbContext
{
    public BooksListDbContext(DbContextOptions<BooksListDbContext> options) : base(options) 
    {
        
    }
}