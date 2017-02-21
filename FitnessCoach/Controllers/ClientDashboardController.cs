using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mongo.Documents;
using Mongo.DataAccess;
using MongoDB.Bson;
using FitnessCoach.Models;

namespace FitnessCoach.Controllers
{
    public class ClientDashboardController : Controller
    {
        // GET: ClientDashboard
        public ActionResult ClientDashboard(string korisnik)
        {
            ClientDashboardModel model = new ClientDashboardModel();
            Session["OdabraniKlijent"] = ObjectId.Parse(korisnik);
            return View(model);
        }


        public ActionResult DodajTrening(string treningID)
        {
            ObjectId i = ObjectId.Parse(treningID);
            ClientDashboardModel model = new ClientDashboardModel();

            Korisnici.DodajTrening((ObjectId)Session["OdabraniKlijent"], i);
            return View("~/Views/ClientDashboard/ClientDashboard.cshtml", model);
        }

        public ActionResult DodajPlanIshrane(string planID)
        {
            ObjectId i = ObjectId.Parse(planID);
            ClientDashboardModel model = new ClientDashboardModel();

            Korisnici.DodajPlanIshrane((ObjectId)Session["OdabraniKlijent"], i);
            return View("~/Views/ClientDashboard/ClientDashboard.cshtml", model);
        }
	}
}