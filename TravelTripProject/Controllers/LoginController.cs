using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Business.Abstract;
using TravelTripProject.Business.Aspects.Postsharp.AuthorizationAspects;
using TravelTripProject.Business.CrossCutingConcers.Security.Web;
using TravelTripProject.Business.DependencyResolvers.Ninject;
using TravelTripProject.Entities.Concrete;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private IUserService _userService;
        public LoginController()
        {
            _userService = InstanceFactory.GetInstance<IUserService>();
        }
        public ActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginPage(User user)
        {
            var user1 = _userService.GetByUserNameAndPassword(user.UserName, user.Password);
            if (user1 != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(),
                    user1.UserName,
                user1.Email,
                DateTime.Now.AddDays(15),
                //new[] {"Student"}, 
                    _userService.GetUserRoles(user1).Select(u => u.RoleName).ToArray(),
                    false,
                    user1.FirstName,
                    user1.LastName);
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginPage", "Login");
        }
    }
}