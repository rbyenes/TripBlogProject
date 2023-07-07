using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.DataAccess.Abstract
{
    public interface ICommentDal : IEntityRepository<Comments>
    {
        List<Comments> Last3Comments();
    }
}
