using Core.Entities;

namespace Entities.Concretes;

public class Teacher : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

}
