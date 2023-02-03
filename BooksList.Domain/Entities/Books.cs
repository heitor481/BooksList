using BooksList.Shared;

namespace BooksList.Domain.Entities;

public class Books : Entity
{
    public Books(string name, DateTime dateLaunched)
    {
        this.Name = name;
        this.DateLaunched = dateLaunched;
    }

    public string Name { get; set; }

    public DateTime DateLaunched { get; set; }
}