using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Business.Abstract;
using TravelTripProject.Business.Aspects.Postsharp.CacheAspects;
using TravelTripProject.Business.CrossCutingConcers.Caching.Microsoft;
using TravelTripProject.DataAccess.Abstract;
using TravelTripProject.DataAccess.Concrete.EntityFramework;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About about)
        {
            _aboutDal.Add(about);
        }

        public void Delete(About about)
        {
            try
            {
                _aboutDal.Delete(about);
            }
            catch
            {
                throw new Exception("Deletion Failed");
            }
        }

        public About Get(int Id)
        {
            return _aboutDal.Get(p => p.ID == Id);
        }
        
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<About> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public void Update(About about)
        {
            _aboutDal.Update(about);
        }
    }
}