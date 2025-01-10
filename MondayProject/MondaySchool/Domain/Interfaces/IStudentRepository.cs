using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IStudentRepository
    {
        Task AddStudentAsync(Student student);
        Task RemoveStudent(Student student);
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentById(int id);

        Task UpdateStudent(Student student);
    }
}