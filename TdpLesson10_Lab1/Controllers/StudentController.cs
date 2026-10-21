
using Microsoft.AspNetCore.Mvc;
using TdpLesson10_Lab1.Models;

namespace TdpLesson10_Lab1.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> listStudents = new List<Student>
        {
            new Student
            {
                Id = 101,
                Name = "Hải Nam",
                Branch = Branch.IT,
                Gender = Gender.Male,
                IsRegular = true,
                Address = "A1-2018",
                Email = "nam@g.com",
                DateOfBorth = new DateTime(2003, 5, 15)
            },
            new Student
            {
                Id = 102,
                Name = "Minh Tú",
                Branch = Branch.BE,
                Gender = Gender.Female,
                IsRegular = true,
                Address = "A1-2019",
                Email = "tu@g.com",
                DateOfBorth = new DateTime(2003, 8, 20)
            },
            new Student
            {
                Id = 103,
                Name = "Hoàng Phong",
                Branch = Branch.CE,
                Gender = Gender.Male,
                IsRegular = false,
                Address = "A1-2020",
                Email = "phong@g.com",
                DateOfBorth = new DateTime(2002, 11, 10)
            },
            new Student
            {
                Id = 104,
                Name = "Xuân Mai",
                Branch = Branch.EE,
                Gender = Gender.Female,
                IsRegular = false,
                Address = "A1-2021",
                Email = "mai@g.com",
                DateOfBorth = new DateTime(2003, 2, 25)
            }
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(listStudents);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.Id = listStudents.Max(x => x.Id) + 1;

            listStudents.Add(s);

            return RedirectToAction("Index");
        }
    }
}
