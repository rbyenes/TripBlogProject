using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProject.Models.Abstract;

namespace TravelTripProject.Models.Entity
{
    public class Address : IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Addres { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}