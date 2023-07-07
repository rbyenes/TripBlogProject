using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.DataAccess.Abstract;
using TravelTripProject.Models.Abstract;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.DataAccess.Concrete.EntityFramework
{
    public class EfBlogDal : EfEntityRepository<Blog, Context>, IBlogDal
    {
        public List<Blog> First3Blogs()
        {
            using (Context context = new Context())
            {
                return context.Set<Blog>().Take(3).ToList();
            }
        }

        public List<Blog> Last10Blogs()
        {
            using (Context context = new Context())
            {
                return context.Set<Blog>().OrderByDescending(x => x.ID).Take(10).ToList();
            }
        }

        public List<Blog> Last2Blogs()
        {
            using (Context context = new Context())
            {
                return context.Set<Blog>().OrderByDescending(x => x.ID).Take(2).ToList();
            }
        }

        public List<Blog> Last3Blogs()
        {
            using (Context context=new Context())
            {
                return context.Set<Blog>().OrderByDescending(x => x.ID).Take(3).ToList();
            }
        }

        public List<Blog> ThirdLastBlog()
        {
            using (Context context = new Context())
            {
                return context.Set<Blog>().OrderByDescending(x => x.ID).Skip(2).Take(1).ToList();
            }
        }
    }
}
