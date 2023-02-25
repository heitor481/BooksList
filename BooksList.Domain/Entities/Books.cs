using System.Security.AccessControl;
using BooksList.Shared;

namespace BooksList.Domain.Entities;

public class Books : Entity
{
    public Books()
    {
        
    }

    public Books(string name, DateTime dateLaunched, Authors author)
    {
        this.Name = name;
        this.DateLaunched = dateLaunched;
        this.Author = author;
    }

    public string Name { get; private set; }

    public DateTime DateLaunched { get; private set; }

    public virtual Authors Author { get; set; }

    public int AuthorId { get; set; }
}