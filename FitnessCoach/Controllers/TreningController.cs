using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mongo.Documents;
using Mongo.DataAccess;
using FitnessCoach.Models;
using System.IO;
using MongoDB.Driver;

namespace FitnessCoach.Controllers
{
    public class TreningController : Controller
    {
        //
        // GET: /Trening/
        public ActionResult ListaTreninga(bool Abdominals = false, bool Back = false, bool Biceps = false, bool Chest = false, bool Legs = false, bool Shoulders = false, bool Triceps = false, bool SelectAll = false)
        {
            TreningModel model = new TreningModel();

            model.Abdominals = Abdominals;
            model.Back = Back;
            model.Biceps = Biceps;
            model.Chest = Chest;
            model.Legs = Legs;
            model.Shoulders = Shoulders;
            model.Triceps = Triceps;
            model.SelectAll = SelectAll;

            return View("~/Views/Trening/ListaTreninga.cshtml", model);
        }

        public ActionResult DodajTrening(string naziv, string misicna_partija, string[] vezbe)
        {
            List<MongoDBRef> lista = new List<MongoDBRef>();
            foreach (string v in vezbe)
            {
                lista.Add(new MongoDBRef("vezbe", v));
            }

            Trening t = new Trening()
            {
                Naziv = naziv,
                Misicna_Partija = misicna_partija,
                Prosecna_Ocena = 0.0f,
                Broj_Ocenjivanja = 0,
                Vezbe = lista
            };

            Treninzi.Dodaj(t);
            return ListaTreninga(false, false, false, false, false, false, false, true);
        }

	}
}