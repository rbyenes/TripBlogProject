using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.Abstract
{
    public interface IAboutService
    {
        List<About> GetAll();
        void Add(About about);
        void Update(About about);
        void Delete(About about);
        About Get(int Id);
    }
}
