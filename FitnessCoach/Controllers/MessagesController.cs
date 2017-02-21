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
    public class MessagesController : Controller
    {
        // GET: Messages
        public ActionResult Index(MessagesModel model)
        {
            model.tekstPoruke = string.Empty;
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult PosaljiPoruku(string primalac, MessagesModel model)
        {
            ObjectId i = ObjectId.Parse(primalac);
            ObjectId id = (ObjectId)Session["Id"];
            Poruka p = new Poruka()
            {
                Vreme_Slanja = DateTime.Now,
                Tekst = model.tekstPoruke,
                Procitana = false,
                Sender_ID = new MongoDBRef("korisnici", id),
                Receiver_ID = new MongoDBRef("korisnici", i)
            };
            Poruke.Dodaj(p);
            model.tekstPoruke = string.Empty;
            return View("~/Views/Messages/Index.cshtml", model);


        }

        public ActionResult PrikaziKonverzacijuInstruktoraKlijenta(string klijent)
        {
            ObjectId id = ObjectId.Parse(klijent);
            MessagesModel model = new MessagesModel();
            if (id != null)
            {
                model.KlijentUKonverzaciji = Korisnici.Procitaj(id);
            }
            else
            {
                model.KlijentUKonverzaciji = new Korisnik();
            }

            return View("~/Views/Messages/Index.cshtml", model);
        }
	}
}