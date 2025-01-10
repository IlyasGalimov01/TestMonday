using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        
        public async Task AddStudentAsync(Student student)
        {
            await _studentRepository.AddStudentAsync(student);
        }
        
        public async Task RemoveStudent(Student student)
        {
          await _studentRepository.RemoveStudent(student);
        }

        public async Task<List<Student>> GetAllStudents()
        {
            return await _studentRepository.GetAllStudents();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _studentRepository.GetStudentById(id);
        }

        public async Task UpdateStudent(Student student)
        {
            await _studentRepository.UpdateStudent(student);
        }
    }
}