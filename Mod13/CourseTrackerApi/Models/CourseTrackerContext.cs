using System.Data.Entity;

namespace CourseTracker.Models
{
    public class CourseTrackerContext: DbContext
    {
        public CourseTrackerContext(): base("DefaultConnection")
        {

        }
        public DbSet<Course> Courses { get; set; }
    }
}