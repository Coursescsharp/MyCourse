using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class HomeController : Controller
    {
        /* Action to display the courses list */
        public IActionResult Index()
        {
            return View();
        }
    }
}