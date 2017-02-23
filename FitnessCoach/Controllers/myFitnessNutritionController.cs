using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitnessCoach.Models;

namespace FitnessCoach.Controllers
{
    public class myFitnessNutritionController : Controller
    {
        // GET: myFitnessNutrition
        public ActionResult myFitnessNutrition()
        {
            PlanIshraneModel model = new PlanIshraneModel();
            return View(model);
        }
    }
}