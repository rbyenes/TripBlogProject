using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProject.Models.Abstract;

namespace TravelTripProject.Models.Entity
{
    public class Comments : IEntity
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}