using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Business.Abstract;
using TravelTripProject.Business.DependencyResolvers.Ninject;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        private ICommentService _commentService;
        public CommentController()
        {
            _commentService = InstanceFactory.GetInstance<ICommentService>();
        }
        public ActionResult CommentList()
        {

            return View(_commentService.GetAll());
        }
        public ActionResult DeleteComment(int id)
        {

            var findComment = _commentService.Get(id);
            _commentService.Delete(findComment);
            return RedirectToAction("CommentList");
        }
        [HttpGet]
        public PartialViewResult DoComment(int id)
        {
            ViewBag.ID = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult DoComment(Comments comments)
        {

            _commentService.Add(comments);
            return PartialView();
        }
        public ActionResult UpdateComment(int id)
        {

            var findComment = _commentService.Get(id);
            return View("UpdateComment",findComment);
        }
        public ActionResult UpdateCommentAction(Comments comments)
        {

            _commentService.Update(comments);
            return RedirectToAction("CommentList");
        }
    }
}