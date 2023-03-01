using BooksList.Domain.Entities;

namespace BooksList.Infra.Repositories.Contracts;

public interface IBooksRepository
{
    Task<List<Books>> GetAllBooks();
}