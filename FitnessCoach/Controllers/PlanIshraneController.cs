using Fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mongo.Documents;
using Mongo.DataAccess;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Fitness.Controllers
{
    public class PlanIshraneController : Controller
    {
        //
        // GET: /PlanIshrane/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaPlanovaIshrane()
        {
            PlanIshraneModel model = new PlanIshraneModel();
            return View("~/Views/PlanIshrane/ListaPlanovaIshrane.cshtml", model);
        }

        public ActionResult DodajPlanIshrane(string naziv)
        {

            Plan_Ishrane plan = new Plan_Ishrane
            {
                Naziv = naziv,
                Broj_Ocenjivanja = 0,
                Prosecna_Ocena = 0,
            };

            PlanIshrane.Dodaj(plan);
            PlanIshraneModel model = new PlanIshraneModel();

            return View("~/Views/PlanIshrane/ListaPlanovaIshrane.cshtml", model);
        }

    }
}