﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mongo.DataAccess;
using Mongo.Documents;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Fitness.Models
{
    public class PlanIshraneModel
    {


        public List<Plan_Ishrane> Planovi { get; set; }

        public List<Plan_Ishrane> PlanoviKorisnika { get; set; }

        public List<Obrok> Obroci { get; set; }

        //public List<Obrok> SviObrociUPlanu(ObjectId planID)
        //{
        //    return ZaRuckanje.SviObrociUPlanu(planID);
        //}

        public List<Namirnica> SveNamirniceUObroku(ObjectId obrokID)
        {
            return ZaRuckanje.SveNamirniceUObroku(obrokID);
        }

        //public string opis(int planID)
        //{
        //    return PlanIshrane.OpisKorisnickogPlana((int)HttpContext.Current.Session["Id"], planID);
        //}
        public Namirnica vratiNamirnicu(MongoDBRef sender)
        {
            return Mongo.Connection<Namirnica>.getDatabase().FetchDBRefAs<Namirnica>(sender);
        }

        public PlanIshraneModel()
        {
            Planovi = new List<Plan_Ishrane>();
            foreach (var ins in PlanIshrane.SviPlanovi())
            {
                Planovi.Add(ins);
            }

            PlanoviKorisnika = new List<Plan_Ishrane>();
            foreach (var ins in Korisnici.SviPlanoviKorisnika((ObjectId)HttpContext.Current.Session["Id"]))
            {
                PlanoviKorisnika.Add(ins);
            }

        }
    }
}