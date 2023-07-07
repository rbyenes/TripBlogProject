using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.Abstract
{
    public interface ICommentService
    {
        List<Comments> GetAll();
        void Add(Comments comments);
        void Update(Comments comments);
        void Delete(Comments comments);
        List<Comments> Last3Comments();
        Comments Get(int id);
    }
}
