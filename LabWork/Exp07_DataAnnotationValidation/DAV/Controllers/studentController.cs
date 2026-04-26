using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
    public IActionResult Index()
        {
            return View(students);
        }
    public IActionResult Create()
    {
            return View();
        }
    static List<Student> students = new List<Student>();
   [HttpPost]
    public IActionResult Create(Student student)
    {
        if(ModelState.IsValid)
        {
            students.Add(student);   // ✅ store data
            return RedirectToAction("Index"); // go to list
        }

        return View(student);
    }
}