using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Business.Abstract;
using TravelTripProject.Business.DependencyResolvers.Ninject;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        private IContactService _contactService;
        private IAddressService _addressService;
        public ContactController()
        {
            _contactService = InstanceFactory.GetInstance<IContactService>();
            _addressService = InstanceFactory.GetInstance<IAddressService>();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            _contactService.Add(contact);
            return View();
        }
        public ActionResult Contact() 
        { 
            return View(_contactService.GetAll()); 
        }
        public PartialViewResult Address()
        {
            return PartialView(_addressService.GetAll());
        }
    }
}