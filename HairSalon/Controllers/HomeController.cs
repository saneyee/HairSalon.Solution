using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/stylists/form")]
        public ActionResult AddStylistForm()
        {
            return View();
        }

        [HttpPost("/stylists")]
        public ActionResult AddStylist()
        {
            Stylist newStylist = new Stylist(Request.Form["stylist-name"]);
            newStylist.Save();
            List<Stylist> allStylists = Stylist.GetAll();
            return View("Stylists", allStylists);
        }

        [HttpGet("/stylists")]
        public ActionResult Stylists()
        {
            List<Stylist> allStylists = Stylist.GetAll();
            return View(allStylists);
        }




















    }
}
