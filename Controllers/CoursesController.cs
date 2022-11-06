using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        private CourseService courseService = new CourseService();

        /* Action to display the courses list */
        public IActionResult Index()
        {
            ViewData["Title"] = "Courses catalog!!!";
            List<CourseViewModel> courses = this.courseService.GetCourses();

            return View(courses);
        }

        /* Action to display a course detail */
        public IActionResult Detail(int id)
        {
            CourseDetailViewModel course = this.courseService.GetCourse(id);
            ViewData["Title"] = course.Title;

            return View(course);
        }

        /* To search courses based on a title */
        public IActionResult Search(string title)
        {
            return View();
        }
    }
}