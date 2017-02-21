using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mongo.Documents;
using Mongo.DataAccess;
using MongoDB.Bson;
using MongoDB.Driver;
using FitnessCoach.Models;

namespace FitnessCoach.Controllers
{
    public class ListaInstruktoraController : Controller
    {
        //
        // GET: /ListaInstruktora/
        public ActionResult ListaFitnessInstruktora()
        {
            ListaInstruktoraModel model = new ListaInstruktoraModel();
            return View(model);
        }

        public ActionResult HireInstructor(string id)
        {
            ObjectId i = ObjectId.Parse(id);
            Korisnici.PromeniInstruktora((ObjectId)Session["Id"], i);
            Session["Instruktor"] = new MongoDBRef("korisnici", i);
            return View("~/Views/ListaInstruktora/ListaFitnessInstruktora.cshtml", new ListaInstruktoraModel());
        }

        public ActionResult fireInstructor(string id)
        {
            ObjectId i = ObjectId.Parse(id);
            Korisnici.PromeniInstruktora((ObjectId)Session["Id"], i);
            Session["Instruktor"] = null;
            return View("~/Views/ListaInstruktora/ListaFitnessInstruktora.cshtml", new ListaInstruktoraModel());
        }
	}
}