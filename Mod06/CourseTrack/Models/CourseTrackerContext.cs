using System.Data.Entity;

namespace CourseTrack.Models
{
    public class CourseTrackerContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

    }
}