using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mongo.Documents;
using Mongo.DataAccess;
using FitnessCoach.Models;
using Mongo;

namespace FitnessCoach.Controllers
{
    public class LogInController : Controller
    {
        //
        // GET: /LogIn/
        public ActionResult Logovanje()
        {
            Mongo.InsertData.Insert();
            LogInModel model = new LogInModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult LogIn(LogInModel model)
        {
            Korisnik user = Korisnici.Procitaj(model.UsernameLogIn);
            if (ModelState.IsValid && user != null && user.Sifra == model.PasswordLogIn)
            {
                Session["user"] = user;
                Session["Id"] = user.Id;
                Session["Username"] = user.Korisnicko_Ime;
                Session["Status"] = user.Status;
                Session["Ime"] = user.Ime;
                Session["Instruktor"] = user.Moj_Instruktor;

                return View("~/Views/Home/HomeStranica.cshtml");
            }
            else
            {
                ViewBag.BadLogin = true;
                return View("Logovanje", model);
            }
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            if (Session["Id"] != null)
            {
                Session["Id"] = null;
                Session["Username"] = null;
                Session["Status"] = null;
                Session["Ime"] = null;
                Session["Instruktor"] = null;
            }

            return RedirectToAction("Logovanje", "LogIn");
        }
	}
}