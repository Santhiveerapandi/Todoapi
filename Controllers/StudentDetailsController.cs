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

    [HttpGet("{id}")]
    public async Task<ActionResult<StudentDetail>> GetStudentDetail(int id)
    {
        var article = await _context.StudentDetails.FindAsync(id);

        if (article == null)
        {
            return NotFound();
        }

        return article;
    }

    [HttpPost]
    public async Task<ActionResult<StudentDetail>> PostStudentDetail(StudentDetail stu)
    {
        _context.StudentDetails.Add(stu);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetStudentDetail", new { id = stu.ID }, stu);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutStudentDetail(int id, StudentDetail stu)
    {
        if (id != stu.ID)
        {
            return BadRequest();
        }

        _context.Entry(stu).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!StudentDetailExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        // return NoContent();
        return Ok(stu);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudentDetail(int id)
    {
        var stu = await _context.StudentDetails.FindAsync(id);
        if (stu == null)
        {
            return NotFound();
        }

        _context.StudentDetails.Remove(stu);
        await _context.SaveChangesAsync();

        // return NoContent();
        return Ok("Successfully Deleted");
    }

    private bool StudentDetailExists(int id)
    {
        return _context.StudentDetails.Any(e => e.ID == id);
    }
}
