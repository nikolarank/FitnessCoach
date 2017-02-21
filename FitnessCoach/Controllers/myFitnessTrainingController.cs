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
    public class myFitnessTrainingController : Controller
    {
        //
        // GET: /myFitnessTraining/
        public ActionResult myFitnessTraining()
        {
            TreningModel model = new TreningModel();
            return View(model);
        }
	}
}