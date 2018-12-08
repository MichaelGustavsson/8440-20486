using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CourseTracker.Models
{
    public class CourseTrackerInitializer: DropCreateDatabaseAlways<CourseTrackerContext>
    {
        protected override void Seed(CourseTrackerContext context)
        {
            base.Seed(context);

            var courses = new List<Course>
            {
                new Course
                {
                    CourseNumber = "8440",
                    Title = "Developing ASP.NET MVC 5 Web Applications",
                    Description = "Awesome course",
                    Days = 5,
                    ReleaseDate = DateTime.Parse("2013-01-01"),
                },

                new Course
                {
                    CourseNumber = "577",
                    Title = "Bygga REST och SOAP Web Services med Java",
                    Description = "Great course for learning how to build services",
                    Days = 5,
                    ReleaseDate = DateTime.Parse("2014-01-01"),
                }
            };

            foreach (var course in courses)
            {
                context.Courses.Add(course);
            }

            context.SaveChanges();
        }
    }
}