using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Business.Abstract;
using TravelTripProject.Business.Aspects.Postsharp.CacheAspects;
using TravelTripProject.Business.Aspects.Postsharp.ValidationAspects;
using TravelTripProject.Business.CrossCutingConcers.Caching.Microsoft;
using TravelTripProject.Business.ValidationRules.FluentValidation;
using TravelTripProject.DataAccess.Abstract;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        [FluentValidationAspect(typeof(BlogValidator))]
        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> First3Blogs()
        {
            return _blogDal.First3Blogs();
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public Blog Get(int blogId)
        {
            return _blogDal.Get(p => p.ID == blogId);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public List<Blog> Last10Blogs()
        {
            return _blogDal.Last10Blogs();
        }

        public List<Blog> Last2Blogs()
        {
            return _blogDal.Last2Blogs();
        }

        public List<Blog> Last3Blogs()
        {
            return _blogDal.Last3Blogs();
        }

        public List<Blog> ThirdLastBlog()
        {
            return _blogDal.ThirdLastBlog();
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}