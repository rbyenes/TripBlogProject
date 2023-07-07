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
    public class AdminManager : IAdminService
    {
        private IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(Admin admin)
        {
            _adminDal.Add(admin);
        }

        public void Delete(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public Admin Get(int adminId)
        {
            return _adminDal.Get(p => p.ID == adminId);
        }

        public List<Admin> GetAll()
        {
            return _adminDal.GetAll();
        }

        public void Update(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
