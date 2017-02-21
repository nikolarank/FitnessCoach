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

            return View(model);
        }

	}
}