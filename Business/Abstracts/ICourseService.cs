using Core.DataAccess.Paging;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Abstracts;

public interface ICourseService
{
    Task Add(Course course);

    Task Delete(Course course);

    Task Update(Course course);

    Task<IPaginate<Course>> GetListAsync();

    Task<IPaginate<CourseDetailsDto>> GetDetailsListAsync();
}
