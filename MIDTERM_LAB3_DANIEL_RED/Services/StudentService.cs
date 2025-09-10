using MIDTERM_LAB3_DANIEL_RED.Models;

namespace MIDTERM_LAB3_DANIEL_RED.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _context;

        public StudentService(StudentDbContext context)
        {
            _context = context;
        }

        public List<StudentDto> GetAll()
        {
            return _context.Students.Select(s => new StudentDto
            {
                Id = s.Id,
                Name = s.Name,
                Age = s.Age,
                Course = s.Course
            }).ToList();
        }

        // Implementation for GetById, Add, Update, Delete would go here
        public StudentDto? GetById(long id) { throw new NotImplementedException(); }
        public void Add(StudentDto student) { throw new NotImplementedException(); }
        public void Update(StudentDto student) { throw new NotImplementedException(); }
        public void Delete(long id) { throw new NotImplementedException(); }
    }
}