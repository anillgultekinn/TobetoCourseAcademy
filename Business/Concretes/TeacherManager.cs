using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class TeacherManager : ITeacherService
    {
        ITeacherDal _teacherDal;

        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public async Task Add(Teacher teacher)
        {
            await _teacherDal.AddAsync(teacher);
        }

        public async Task Delete(Teacher teacher)
        {
            await _teacherDal.DeleteAsync(teacher);
        }

        public async Task<IPaginate<Teacher>> GetListAsync()
        {
            return await _teacherDal.GetListAsync();
        }

        public Task Update(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
