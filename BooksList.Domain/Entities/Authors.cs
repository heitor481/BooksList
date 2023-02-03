using BooksList.Shared;

namespace BooksList.Domain.Entities;

public class Authors : Entity
{
    public Authors(string name, string surName)
    {
        this.Name = name;
        this.SurName = surName;
    }

    public string Name { get; set; }

    public string SurName { get; set; }
    
    public ICollection<Books> Books { get; private set; }
}