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
using TravelTripProject.DataAccess.Concrete.EntityFramework;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        [FluentValidationAspect(typeof(CommentValidator))]
        public void Add(Comments comments)
        {
            _commentDal.Add(comments);
        }

        public void Delete(Comments comments)
        {
            _commentDal.Delete(comments);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public Comments Get(int id)
        {
            return _commentDal.Get(p => p.ID == id);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Comments> GetAll()
        {
            return _commentDal.GetAll();
        }

        public List<Comments> Last3Comments()
        {
            return _commentDal.Last3Comments();
        }

        public void Update(Comments comments)
        {
            _commentDal.Update(comments);
        }
    }
}
