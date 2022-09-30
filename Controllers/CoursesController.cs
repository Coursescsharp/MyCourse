using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        /* Action to display the courses list */
        public IActionResult Index()
        {
            return Content("I am Index");
        }

        /* Action to display a course detail */
        public IActionResult Detail(string id)
        {
            return Content($"I am Detail and I received the id {id}");
        }
    }
}