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
    public class ContactManager : IContactService
    {
        private IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public void Delete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public Contact Get(int Id)
        {
            return _contactDal.Get(p => p.ID == Id);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
