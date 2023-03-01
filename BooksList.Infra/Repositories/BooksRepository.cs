using BooksList.Domain.Entities;
using BooksList.Infra.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BooksList.Infra.Repositories;

public class BooksRepository : IBooksRepository
{
    private readonly BooksListDbContext context;
    
    public BooksRepository(BooksListDbContext booksListDbContext)
    {
        this.context = context;
    }

    public async Task<List<Books>> GetAllBooks()
    {
        return await this.context.Books.ToListAsync();
    }
}