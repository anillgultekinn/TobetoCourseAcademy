using Core.DataAccess.Paging;
using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;
using Entities.DTOs;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfRepositoryBase<Course, Guid, TobetoContext>, ICourseDal
    {
        TobetoContext _context;
        public EfCourseDal(TobetoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IPaginate<CourseDetailsDto>> GetCourseDetails()
        {
            int index = 0;
            int size = 20;

            var result = await (from course in _context.Courses
                                join category in _context.Categories
                                on course.CategoryId equals category.Id
                                join teacher in _context.Teachers
                                on course.TeacherId equals teacher.Id
                                select new CourseDetailsDto
                                {
                                    Id = course.Id,
                                    CategoryName = category.Name,
                                    CourseName = course.Name,
                                    Description = course.Description,
                                    TeacherName = teacher.Name,

                                }).ToPaginateAsync(index, size, 0);

            return result;
        }
    }
}
