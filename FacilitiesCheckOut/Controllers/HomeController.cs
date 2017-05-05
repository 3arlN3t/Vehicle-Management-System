﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FacilitiesCheckOut.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reports()
        {
            ViewBag.Message = "Your application reports page.";

            return View();
        }

        public ActionResult VehicleInOutChoose()//-vvvvvv-Vehicle Pages-vvvvvv-\\
        {
            ViewBag.Message = "Your application Vehicle Sign In/Out page.";

            return View();
        }

        public ActionResult VehicleCheckout()
        {
            ViewBag.Message = "Your Vehicle Checkout page.";

            return View();
        }

        public ActionResult VehicleReturn()
        {
            ViewBag.Message = "Your Vehicle Return Page.";

            return View();
        }

        public ActionResult GasCardInOutChoose()//-vvvvvv-Gas Card Pages-vvvvvv-\\
        {
            ViewBag.Message = "Your application Gas Card Sign In/Out page.";

            return View();
        }

        public ActionResult GasCardCheckout()
        {
            ViewBag.Message = "Your Gas Card Checkout Page.";

            return View();
        }

        public ActionResult GasCardReturn()
        {
            ViewBag.Message = "Your Gas Card Return Page.";

            return View();
        }


    }
}