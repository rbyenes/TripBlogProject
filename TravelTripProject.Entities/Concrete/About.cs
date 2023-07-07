using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProject.Models.Abstract;

namespace TravelTripProject.Models.Entity
{
    public class About : IEntity
    {
        public int ID { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
    }
}