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
    public class AddressManager : IAddressService
    {
        private IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void Add(Address address)
        {
            _addressDal.Add(address);
        }

        public void Delete(Address address)
        {
            _addressDal.Delete(address);
        }

        public Address Get(int addressId)
        {
            return _addressDal.Get(p => p.ID == addressId);
        }

        public List<Address> GetAll()
        {
            return _addressDal.GetAll();
        }

        public void Update(Address address)
        {
            _addressDal.Update(address);
        }
    }
}
