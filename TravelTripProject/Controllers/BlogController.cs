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
    public class BlogController : Controller
    {
        // GET: Blog
        Context _context = new Context();
        BlogComment _blogComment = new BlogComment();
        public ActionResult Index()
        {
            _blogComment.Value1 = _context.Blogs.ToList();
            _blogComment.Value3 = _context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            _blogComment.Value4 = _context.Commentses.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(_blogComment);
        }
        
        public ActionResult BlogDetails(int id)
        {
            
            _blogComment.Value1 = _context.Blogs.Where(x=>x.ID == id).ToList();
            _blogComment.Value2 = _context.Commentses.Where(x=>x.BlogId == id).ToList();
            return View(_blogComment);
        }
    }
}