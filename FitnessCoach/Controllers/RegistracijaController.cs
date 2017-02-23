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
    public class RegistracijaController : Controller
    {
        //
        // GET: /Registracija/
        public ActionResult Registracija()
        {
            RegistracijaModel model = new RegistracijaModel();
            return View(model);
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(RegistracijaModel model)
        {

            if (ModelState.IsValid)
            {
                Korisnik user = new Korisnik()
                {
                    Ime = model.ImeRegistracija,
                    Prezime = model.PrezimeRegistracija,
                    Korisnicko_Ime = model.UsernameRegistracija,
                    Sifra = model.PasswordRegistracija,
                    Email = model.EmailRegistracija,
                    Biografija = "",
                    Broj_Ocenjivanja = 0,
                    Rang = 9.0,
                    Status = "korisnik",
                    Moj_Instruktor = null,
                    Slika = "unknown-person.jpg",
                    Zahtev_Za_Instruktora = false
                };

                Korisnici.Dodaj(user);
                return View("~/Views/LogIn/Logovanje.cshtml");
            }
            else
            {
                return View("Registracija", model);
            }

        }
	}
}