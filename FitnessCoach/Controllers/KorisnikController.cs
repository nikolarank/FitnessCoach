using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mongo.Documents;
using Mongo.DataAccess;
using System.IO;
using MongoDB.Bson;
using FitnessCoach.Models;

namespace FitnessCoach.Controllers
{
    public class KorisnikController : Controller
    {
        //
        // GET: /Profil/
        public ActionResult ProfilnaKorisnikInstruktor()
        {
            KorisnikModel model = new KorisnikModel();
            return View(model);
        }

        public ActionResult ProfilnaAdministrator()
        {
            AdministratorModel model = new AdministratorModel();
            return View(model);
        }

        public ActionResult KorisnikToInstruktor(string id)
        {
            ObjectId i = ObjectId.Parse(id);
            Korisnici.KonvertujUInstruktora(i);

            AdministratorModel model = new AdministratorModel();

            return View("~/Views/Korisnik/ProfilnaAdministrator.cshtml", model);
        }

        public ActionResult InstruktorToKorisnik(ObjectId id)
        {
            Korisnici.KonvertujUKorisnika(id);

            AdministratorModel model = new AdministratorModel();

            return View("~/Views/Korisnik/ProfilnaAdministrator.cshtml", model);
        }

        public ActionResult OdbijenZahtev(string id)
        {
            ObjectId i = ObjectId.Parse(id);
            Korisnici.OdbijZahtevZaInstruktora(i);
            AdministratorModel model = new AdministratorModel();
            return View("~/Views/Korisnik/ProfilnaAdministrator.cshtml", model);
        }

        public ActionResult BrisiKorisnika(string id)
        {
            ObjectId i = ObjectId.Parse(id);
            Korisnici.ObrisiKorisnika(i);

            AdministratorModel model = new AdministratorModel();

            return View("~/Views/Korisnik/ProfilnaAdministrator.cshtml", model);
        }

        [HttpPost]
        public ActionResult IzmeniSliku(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                Korisnici.PromeniSliku((ObjectId)Session["id"], Path.GetFileName(file.FileName));
                string path = Path.Combine(Server.MapPath("~/Content/profilneSlike"), Path.GetFileName(file.FileName));
                file.SaveAs(path);
            }
            ((Korisnik)Session["user"]).Slika = Path.GetFileName(file.FileName);
            KorisnikModel model = new KorisnikModel();
            return View("~/Views/Korisnik/ProfilnaKorisnikInstruktor.cshtml", model);
        }

        public ActionResult zahtevajInstruktora()
        {
            Korisnici.PostaniInstruktor((ObjectId)Session["Id"]);

            KorisnikModel model = new KorisnikModel();

            return View("~/Views/Korisnik/ProfilnaKorisnikInstruktor.cshtml", model);
        }

        public ActionResult PromeniBiografiju()
        {
            KorisnikModel model = new KorisnikModel();

            Korisnici.PromeniBiografiju((Korisnik)Session["user"], model.biografija);
            return View("~/Views/Korisnik/ProfilnaAdministrator.cshtml", model);
        }
	}
}