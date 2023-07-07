using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProject.Models.Abstract;

namespace TravelTripProject.Models.Entity
{
    public class Contact : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Topic { get; set; }
        public string Message { get; set; }
    }
}