using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Business.Abstract;
using TravelTripProject.Models.Entity;
using TravelTripProject.Business.Aspects.Postsharp.AuthorizationAspects;
using TravelTripProject.Business.DependencyResolvers.Ninject;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private IBlogService _blogService;
        public AdminController()
        {
            _blogService = InstanceFactory.GetInstance<IBlogService>();
        }

        
        [SecuredOperation(Roles = "Admin,Editor")]
        [Authorize]
        public ActionResult Index()
        {

            return View(_blogService.GetAll());
        }
        
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult NewBlog(Blog newBlog)
        {
            _blogService.Add(newBlog);
            return RedirectToAction("Index");
        }
        
        public ActionResult DeleteBlog(int id)
        {
            var findBlog = _blogService.Get(id);
            _blogService.Delete(findBlog);
            return RedirectToAction("Index");
        }
        
        public ActionResult UpdateBlog(int id)
        {
            var findBlog = _blogService.Get(id);
            return View("UpdateBlog", findBlog);
        }
        
        public ActionResult UpdateBlogAction(Blog blog)
        {
            _blogService.Update(blog);
            return RedirectToAction("Index");

        }
    } 
}