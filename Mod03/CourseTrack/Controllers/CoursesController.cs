using CourseTrack.Models;
using CourseTrack.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseTrack.Controllers
{
    public class CoursesController : Controller
    {
        //readonly CourseTrackerContext _context = new CourseTrackerContext();
        ICourseRepository _repo = new CourseRepository();

        public ActionResult Index()
        {
            // var courses = _context.Courses.ToList();
            var courses = _repo.ListCourses();

            return View(courses);
        }
    }
}