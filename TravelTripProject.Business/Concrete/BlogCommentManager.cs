using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Business.Abstract;
using TravelTripProject.DataAccess.Abstract;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.Concrete
{
    public class BlogCommentManager : IBlogCommentService
    {
        private IBlogCommentDal _blogCommentDal;
        public BlogCommentManager(IBlogCommentDal blogCommentDal)
        {
            _blogCommentDal = blogCommentDal;
        }
    }
}
