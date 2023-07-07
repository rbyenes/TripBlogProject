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
    public class AboutController : Controller
    {
        // GET: About
        private IAboutService _aboutService;
        public AboutController()
        {
            _aboutService = InstanceFactory.GetInstance<IAboutService>();
        }
        public ActionResult Index()
        {

            return View(_aboutService.GetAll());
        }
        public ActionResult About()
        {
            return View("About",_aboutService.Get(1));
        }
        public ActionResult UpdateAbout(About about)
        {
            _aboutService.Update(about);
            return RedirectToAction("About");
        }
    }
}