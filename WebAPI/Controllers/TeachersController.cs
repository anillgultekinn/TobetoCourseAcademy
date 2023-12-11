using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("getteacherlist")]

        public async Task<IActionResult> GetTeacherList()
        {
            var result = await _teacherService.GetListAsync();
            return Ok(result);
        }

        [HttpPost("add")]

        public async Task<IActionResult> Add([FromBody] Teacher teacher)
        {
            await _teacherService.Add(teacher);
            return Ok();
        }

        [HttpPost("delete")]

        public async Task<IActionResult> Delete([FromBody] Teacher teacher)
        {
            await _teacherService.Delete(teacher);
            return Ok();
        }

        [HttpPost("update")]

        public async Task<IActionResult> Update([FromBody] Teacher teacher)
        {
            await _teacherService.Update(teacher);
            return Ok();
        }

    }
}
