using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class StudentController : Controller
{
   private readonly StudentService _studentService;

   public StudentController(StudentService studentService)
   {
      _studentService = studentService;
   }

   public async Task<IActionResult> Index()
   {
      List<Student> students = await _studentService.GetAllStudents();
      return View(students);
   }
}