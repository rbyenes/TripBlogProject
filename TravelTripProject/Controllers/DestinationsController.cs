﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProject.Controllers
{
    public class DestinationsController : Controller
    {
        // GET: Destinations
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hotels()
        {
            return View();
        }
        public ActionResult Restaurants()
        {
            return View();
        }
        public ActionResult BeachResorts()
        {
            return View();
        }
    }
}