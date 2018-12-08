using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CourseTrack.Models
{
    public class CourseTrackerContext: DbContext
    {
        public CourseTrackerContext():base("DefaultConnection")
        {
            Database.CommandTimeout = 180;
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

    }
}