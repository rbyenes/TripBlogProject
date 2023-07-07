using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProject.Models.Abstract;

namespace TravelTripProject.Models.Entity
{
    public class Admin : IEntity
    {
        
        public int ID { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}