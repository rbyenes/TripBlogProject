using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.DataAccess.Abstract;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.DataAccess.Concrete.EntityFramework
{
    public class EfCommentDal : EfEntityRepository<Comments, Context>, ICommentDal
    {
        public List<Comments> Last3Comments()
        {
            using (Context context=new Context())
            {
                return context.Set<Comments>().OrderByDescending(x => x.ID).Take(3).ToList();
            }
        }
    }
}
