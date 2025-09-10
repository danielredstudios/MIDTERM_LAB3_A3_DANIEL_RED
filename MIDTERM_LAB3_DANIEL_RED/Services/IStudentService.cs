using MIDTERM_LAB3_DANIEL_RED.Models;

namespace MIDTERM_LAB3_DANIEL_RED.Services
{
    public interface IStudentService
    {
        List<StudentDto> GetAll();
        StudentDto? GetById(long id);
        void Add(StudentDto student);
        void Update(StudentDto student);
        void Delete(long id);
    }
}