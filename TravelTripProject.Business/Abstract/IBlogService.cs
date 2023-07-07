using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(Blog blog);
        List<Blog> Last3Blogs();
        List<Blog> Last2Blogs();
        List<Blog> ThirdLastBlog();
        List<Blog> Last10Blogs();
        List<Blog> First3Blogs();
        Blog Get(int blogId);
    }
}
