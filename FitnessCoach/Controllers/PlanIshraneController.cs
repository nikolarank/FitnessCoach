using FitnessCoach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mongo.Documents;
using Mongo.DataAccess;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FitnessCoach.Controllers
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

        public ActionResult DodajObrok(int rednibroj, string[] namirnice)
        {

            Obrok o = new Obrok
            {
                Redni_Broj_Obroka = rednibroj,
            };

            foreach (string namirnicaId in namirnice)
            {
                ObjectId id = ObjectId.Parse(namirnicaId);
                MongoDBRef r = new MongoDBRef("namirnice", id);
                o.Namirnice.Add(r);
            }
            
            Obroci.Dodaj(o);
            PlanIshraneModel model = new PlanIshraneModel();
            model.Obroci.Add(o);

            return View("~/Views/PlanIshrane/ListaPlanovaIshrane.cshtml", model);
        }
    }
}