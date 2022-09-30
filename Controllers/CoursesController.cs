using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        /* Action to display the courses list */
        public IActionResult Index()
        {
            return View();
        }

        /* Action to display a course detail */
        public IActionResult Detail(string id)
        {
            return View();
        }

        /* To search courses based on a title */
        public IActionResult Search(string title)
        {
            return View();
        }
    }
}