using BooksList.Infra.Repositories;
using BooksList.Infra.Repositories.Contracts;

namespace BooksList.Application.Midlewares.Books;

public class BooksMidleware
{
    private readonly IBooksRepository _booksRepository;
    
    public BooksMidleware(BooksRepository booksRepository)
    {
        this._booksRepository = booksRepository;
    }
}