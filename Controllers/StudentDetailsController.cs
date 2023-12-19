using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    
    private readonly ILogger<StudentController> _logger;
    private readonly StudentDetailContext _context;
    public StudentController(ILogger<StudentController> logger, StudentDetailContext context)
    {
        _logger = logger;
        _context=context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<StudentDetail>>> GetStudentDetails() {
        return await _context.StudentDetails.ToListAsync();
    }
}