using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mongo.DataAccess;
using Mongo.Documents;

namespace FitnessCoach.Models
{
    public class AdministratorModel
    {
        public List<Korisnik> Korisnicii { get; set; }

        public List<Korisnik> Instruktori { get; set; }

        public AdministratorModel()
        {
            Korisnicii = new List<Korisnik>();
            foreach (var ins in Korisnici.SviKorisnici())
            {
                Korisnicii.Add(ins);
            }

            Instruktori = new List<Korisnik>();
            foreach (var ins in Korisnici.SviInstruktori())
            {
                Instruktori.Add(ins);
            }
        }
    }
}