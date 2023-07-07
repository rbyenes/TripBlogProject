using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetAll();
        void Add(Admin admin);
        void Update(Admin admin);
        void Delete(Admin admin);
        Admin Get(int adminId);
    }
}
