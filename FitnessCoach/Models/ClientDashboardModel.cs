using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mongo.DataAccess;
using Mongo.Documents;
using MongoDB.Bson;

namespace FitnessCoach.Models
{
    public class ClientDashboardModel:Slika
    {
        public string opisPlanaTreninga { get; set; }

        public string opisPlanaIshrane { get; set; }

        public Vezba SelektovanaVezba { get; set; }
        public List<Vezba> DodateVezbe { get; set; }

        public List<Trening> SviTreninzi()
        {
            return Treninzi.SviTreninzi();
        }

        public List<Plan_Ishrane> SviPlanoviIshrane()
        {
            return PlanIshrane.SviPlanovi();
        }

        public Korisnik castSesijuUKlijenta()
        {
            return Korisnici.Procitaj((ObjectId)HttpContext.Current.Session["OdabraniKlijent"]);
        }

        public ClientDashboardModel()
        {
            DodateVezbe = new List<Vezba>();
        }
    }
}