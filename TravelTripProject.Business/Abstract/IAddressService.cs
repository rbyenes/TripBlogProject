using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.Abstract
{
    public interface IAddressService
    {
        List<Address> GetAll();
        void Add(Address address);
        void Update(Address address);
        void Delete(Address address);
        Address Get(int addressId);
    }
}
