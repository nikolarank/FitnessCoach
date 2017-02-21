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
    public class ListaKlijenataController : Controller
    {
        //
        // GET: /ListaKlijenata/
        public ActionResult ListaKlijenata()
        {
            ListaKlijenataModel model = new ListaKlijenataModel();
            return View(model);
        }

	}
}