using System;
using System.Collections.Generic;
using MyCourse.Models.ViewModels;
using MyCourse.Models.Enums;
using MyCourse.Models.ValueTypes;

namespace MyCourse.Models.Services.Application
{
    public class CourseService
    {
        public List<CourseViewModel> GetCourses()
        {
            List<CourseViewModel> coursesList = new List<CourseViewModel>();
            Random rand = new Random();

            for (int i = 1; i <= 20; i++)
            {
                decimal price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
                CourseViewModel course = new CourseViewModel
                {
                    Id = i,
                    Title = $"Course {i}",
                    CurrentPrice = new Money(Currency.EUR, price),
                    FullPrice = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price + 1),
                    Author = "Name Lastname",
                    Rating = rand.Next(10, 50) / 10.0,
                    ImagePath = "/logo.svg"
                };

                coursesList.Add(course);
            }

            return coursesList;
        }

        public CourseDetailViewModel GetCourse(int id)
        {
            Random rand = new Random();
            decimal price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
            CourseDetailViewModel course = new CourseDetailViewModel
            {
                Id = id,
                Title = $"Course {id}",
                CurrentPrice = new Money(Currency.EUR, price),
                FullPrice = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price + 1),
                Author = "Name Lastname",
                Rating = rand.Next(10, 50) / 10.0,
                ImagePath = "/logo.svg",
                Description = $"Description {id}",
                Lessons = new List<LessonViewModel>()
            };

            for (int i = 1; i <= 5; i++)
            {
                LessonViewModel lesson = new LessonViewModel {
                    Title = $"Lesson {i}",
                    Duration = TimeSpan.FromSeconds(rand.Next(40, 90))
                };

                course.Lessons.Add(lesson);
            }

            return course;
        }
    }
}