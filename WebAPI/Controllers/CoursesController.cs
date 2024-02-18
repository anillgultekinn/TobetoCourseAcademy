using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    ICourseService _courseService;
    public CoursesController(ICourseService courseService)
    {
        _courseService = courseService;
    }


    [HttpGet("getList")]
    public async Task<IActionResult> GetList()
    {
        var result = await _courseService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("getCourseDetails")]
    public async Task<IActionResult> GetCourseDetailList()
    {
        var result = await _courseService.GetDetailsListAsync();
        return Ok(result);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] Course course)
    {
        await _courseService.Add(course);
        return Ok();
    }

    [HttpPost("delete")]
    public async Task<IActionResult> Delete([FromBody] Course course)
    {
        await _courseService.Delete(course);
        return Ok();
    }
}