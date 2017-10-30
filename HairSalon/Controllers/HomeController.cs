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

        [HttpGet("/stylists/{id}")]
        public ActionResult StylistDetail(int id)
        //id = 1
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist selectedStylist = Stylist.Find(id);
            List<Client> stylistClients = selectedStylist.GetClients();
            model.Add("stylist", selectedStylist);
            model.Add("clients", stylistClients);
            return View(model);
        }

        [HttpGet("/stylists/{id}/clients/new")]
        public ActionResult AddClient(int id)
        {
            Stylist selectedStylist = Stylist.Find(id);
            return View(selectedStylist);
        }

        [HttpPost("/stylists/{id}/clientlist")]
        public ActionResult AddEachClient(int id)
        {
            Client newClient = new Client(Request.Form["client-name"], id);
            newClient.Save();
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist selectedStylist = Stylist.Find(id); //Stylist is selected as an object
            List<Client> allClients = selectedStylist.GetClients();
            model.Add("stylist", selectedStylist);
            model.Add("clients", allClients);
            return View("StylistDetail", model);
        }

        [HttpGet("/stylists/{id}/clientlist")]
        public ActionResult ViewClientList(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist selectedStylist = Stylist.Find(id); //Stylist is selected as an object
            List<Client> allClients = selectedStylist.GetClients();
            model.Add("stylist", selectedStylist);
            model.Add("clients", allClients);
            return View("StylistDetail", model);
        }

    //   [HttpGet("/stylists/{id}/clients/new")]
    //   public ActionResult AddClient(int id)
    //   {
    //       Dictionary<string, object> model = new Dictionary<string, object>();
    //       Stylist selectedStylist = Stylist.Find(id);
    //       List<Client> allClients = selectedStylist.GetClients();
    //       model.Add("stylist", selectedStylist);
    //       model.Add("clients", allClients);
    //       return View(model);
    //   }


























    }
}
