using Core.Entities;

namespace Entities.Concretes;

public class Course : Entity<Guid>
{
    public int CategoryId { get; set; }
    public int TeacherId { get; set; }
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public string Description { get; set; }
}
