using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ITeacherDal : IRepository<Teacher, Guid>, IAsyncRepository<Teacher, Guid>
{
}
