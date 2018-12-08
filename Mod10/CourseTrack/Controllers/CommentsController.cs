using CourseTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseTrack.Controllers
{
    public class CommentsController : Controller
    {
        CourseTrackerContext _context = new CourseTrackerContext();

        public ActionResult _GetCommentsForCourse(int courseId)
        {
            ViewBag.CourseId = courseId;
            var comments = _context.Comments.Where(c => c.CourseId == courseId).ToList();

            return PartialView("_GetCommentsForCourse", comments);
        }

        [ChildActionOnly]
        public ActionResult _GetCommentForm(int courseId)
        {
            Comment comment = new Comment() { CourseId = courseId };
            return PartialView("_CommentForm", comment);
        }

        public ActionResult _SaveComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();

            var comments = _context.Comments.Where(c => c.CourseId == comment.CourseId).ToList();
            ViewBag.CourseId = comment.CourseId;
            return PartialView("_GetCommentsForCourse", comments);
        }
    }
}