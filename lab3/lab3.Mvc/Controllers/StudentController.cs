using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab3.Mvc.Models;

namespace lab3.Mvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public IActionResult Index()
        {
            IEnumerable<StudentViewModel> students = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                //HTTP GET
                var responseTask = client.GetAsync("student");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<StudentViewModel>>();
                    readTask.Wait();
                    students = readTask.Result;
                }
                else //web api sent error response
                {
                    //log response status here..
                    students = Enumerable.Empty<StudentViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(students);
        }
    }
}