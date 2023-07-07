using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProject.Models.Abstract;

namespace TravelTripProject.Models.Entity
{
    public class Blog : IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comments> Commentses { get; set; }
    }
}