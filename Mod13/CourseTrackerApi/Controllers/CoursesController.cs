using CourseTracker.Models;
using System;
using System.Linq;
using System.Web.Http;

namespace CourseTrackerApi.Controllers
{
    public class CoursesController : ApiController
    {
        CourseTrackerContext _context = new CourseTrackerContext();

        public IHttpActionResult Get()
        {         
            var result = _context.Courses.ToList();

            if(result != null)
                return Ok(result);

            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult Save(Course model)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest();

                _context.Courses.Add(model);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }            
        }
    }
}
