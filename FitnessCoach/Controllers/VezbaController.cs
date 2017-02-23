using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mongo.Documents;
using Mongo.DataAccess;
using FitnessCoach.Models;
using System.IO;

namespace FitnessCoach.Controllers
{
    public class VezbaController : Controller
    {
        //
        // GET: /Vezba/
        public ActionResult ListaVezbi(bool Abdominals = false, bool Back = false, bool Biceps = false, bool Chest = false, bool Legs = false, bool Shoulders = false, bool Triceps = false, bool SelectAll = false)
        {
            VezbaModel model = new VezbaModel();

            model.Abdominals = Abdominals;
            model.Back = Back;
            model.Biceps = Biceps;
            model.Chest = Chest;
            model.Legs = Legs;
            model.Shoulders = Shoulders;
            model.Triceps = Triceps;
            model.SelectAll = SelectAll;

            return View("~/Views/Vezba/ListaVezbi.cshtml", model);
        }

        public ActionResult DodajVezbu(HttpPostedFileBase file, string naziv, string tekst, string misicna_partija)
        {
            Vezba v = new Vezba()
            {
                Naziv = naziv,
                Tekst = tekst,
                Misicna_Partija = misicna_partija,
                Prosecna_Ocena = 9.0,
                Broj_Ocenjivanja = 0
            };

            if (file != null && file.ContentLength > 0)
            {
                v.Slika = file.FileName;
                string path = Path.Combine(Server.MapPath("~/Content/slikeVezbi/" + misicna_partija), Path.GetFileName(file.FileName));
                file.SaveAs(path);
            }
            Vezbe.Dodaj(v);
            return ListaVezbi(false, false, false, false, false, false, false, true);
        }
	}
}