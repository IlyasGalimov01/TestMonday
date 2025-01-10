using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly Context _context;

        public StudentRepository(Context context)
        {
            _context = context;
        }
        
        public async Task AddStudentAsync(Student student)
        {
            await _context.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveStudent(Student student)
        {
            _context.Remove(student);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllStudents()
        {
            List<Student> students = await _context.Students.ToListAsync();
            return students;
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(s=> s.Id == id);
        }

        public async Task UpdateStudent(Student student)
        {
            _context.Update(student);
            await _context.SaveChangesAsync();
        }
    }
}