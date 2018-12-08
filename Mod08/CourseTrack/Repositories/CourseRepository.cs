using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CourseTrack.Models;

namespace CourseTrack.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CourseTrackerContext _context;
        public CourseRepository()
        {
            _context = new CourseTrackerContext();
        }
        public IList<Course> ListCourses()
        {
            return _context.Courses.ToList();
        }
    }
}