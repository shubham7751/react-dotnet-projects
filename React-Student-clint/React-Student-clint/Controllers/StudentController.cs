using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using React_Student_clint.Data;
using React_Student_clint.Models;

namespace React_Student_clint.Controllers
{
    [Route("api/Student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly StudentDbContext _context;

        public StudentController(StudentDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetStudent")]
        public async Task<IEnumerable<Student>> GetStudent()
        {
            return await _context.Students.ToListAsync();
        }

        [HttpPost]
        [Route("AddStudent")]
        public async Task<Student> AddStudent(Student objStudent)
        {
            _context.Students.Add(objStudent);
            await _context.SaveChangesAsync();
            return objStudent;
        }
        [HttpPatch]
        [Route("UpdateStudent/{id}")]
        public async Task<Student> UpdateStudent(Student objStudent)
        {
            _context.Entry(objStudent).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return objStudent;
        }
        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public bool DeleteStudent(int id)
        {
            bool a = false;
            var student = _context.Students.Find(id);



            if (student != null)
            {
                a = true;
                _context.Entry(student).State = EntityState.Deleted;
                _context.SaveChanges();

            }
            else
            {
                a = false;
            }
            return a;
        }
    }
}
