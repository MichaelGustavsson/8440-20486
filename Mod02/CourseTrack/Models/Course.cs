using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseTrack.Models
{
	public class Course
	{
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Days { get; set; }
        public Instructor Instructor { get; set; }
    }
}