using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ITeacherService
{
    Task<IPaginate<Teacher>> GetListAsync();
    Task Add(Teacher teacher);
    Task Update(Teacher teacher);
    Task Delete(Teacher teacher);
}
