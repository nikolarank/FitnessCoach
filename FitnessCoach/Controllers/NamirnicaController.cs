using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mongo.Documents;
using Mongo.DataAccess;
using FitnessCoach.Models;

namespace FitnessCoach.Controllers
{
    public class NamirnicaController : Controller
    {
        //
        // GET: 
        public ActionResult ListaNamirnica()
        {
            NamirnicaModel model = new NamirnicaModel();
            return View(model);
        }

        public ActionResult ListaPlanovaTreninga()
        {
            return View("~/Views/Vezbe/listaPlanovaTreninga.cshtml");
        }

        public ActionResult DodajNamirnicu(string naziv, string kalorije, string proteini, string uh, string masti)
        {
            Namirnica n = new Namirnica
            {
                Naziv = naziv,
                Kalorije = kalorije,
                Proteini = proteini,
                Uh = uh,
                Masti = masti
            };
            Namirnice.Dodaj(n);
            NamirnicaModel model = new NamirnicaModel();
            return View("~/Views/Namirnica/ListaNamirnica.cshtml", model);
        }
	}
}