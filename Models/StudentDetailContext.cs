using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class StudentDetailContext : DbContext
    {
        public StudentDetailContext(DbContextOptions<StudentDetailContext> options) : base(options)
        {

        }
        public DbSet<StudentDetail> StudentDetails { get; set; }
        //Table Name StudentDetails
    }
}
