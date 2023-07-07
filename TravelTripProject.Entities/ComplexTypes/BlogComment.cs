using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProject.Entities.Abstract;
using TravelTripProject.Models.Abstract;

namespace TravelTripProject.Models.Entity
{
    public class BlogComment : IComplex
    {
        public IEnumerable<Blog> Value1 { get; set; }
        public IEnumerable<Comments> Value2 { get; set; }
        public IEnumerable<Blog> Value3 { get; set; }
        public IEnumerable<Comments> Value4 { get; set; }
    }
}