using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseTrack.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        [StringLength(512)]

        [DisplayName("Comment")]
        public string Body { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}