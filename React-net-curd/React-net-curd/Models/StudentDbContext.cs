using Microsoft.EntityFrameworkCore;

namespace React_net_curd.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public  DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=NTS-SHUBHAMJ\\MSSQLSERVER2023;database=Student_Data;Trusted_Connection=True;TrustServerCertificate=Yes");
        }
    }
}
