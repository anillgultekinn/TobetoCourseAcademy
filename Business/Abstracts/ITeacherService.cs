using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ITeacherService
    {
        Task<IPaginate<Teacher>> GetListAsync();
        Task Add(Teacher teacher);
        Task Update(Teacher teacher);
        Task Delete(Teacher teacher);

    }
}
