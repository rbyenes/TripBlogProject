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
    public class DefaultController : Controller
    {
        // GET: Default
        private IBlogService _blogService;
        public DefaultController()
        {
            _blogService = InstanceFactory.GetInstance<IBlogService>();
        }

        public ActionResult Index()
        {
            var blogs = _blogService.GetAll();
            return View(blogs);
        }
        public PartialViewResult Partial1()
        {

            return PartialView(_blogService.Last2Blogs());
        }
        public PartialViewResult Partial2()
        {
            return PartialView(_blogService.ThirdLastBlog());
        }
        public PartialViewResult Partial3()
        {
            return PartialView(_blogService.Last10Blogs());
        }
        public PartialViewResult Partial4()
        {
            return PartialView(_blogService.First3Blogs());
        }
        public PartialViewResult Partial5()
        {
            return PartialView(_blogService.Last3Blogs());
        }
    }
}