using Microsoft.EntityFrameworkCore;
using React_Student_clint.Models;

namespace React_Student_clint.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
