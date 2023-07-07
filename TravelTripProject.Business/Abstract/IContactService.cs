using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.Abstract
{
    public interface IContactService
    {
        List<Contact> GetAll();
        void Add(Contact contact);
        void Update(Contact contact);
        void Delete(Contact contact);
        Contact Get(int Id);
    }
}
