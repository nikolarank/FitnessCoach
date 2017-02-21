using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mongo.DataAccess;
using Mongo.Documents;

namespace FitnessCoach.Models
{
    public class KorisnikModel:Slika
    {
        public string biografija { get; set; }

        public Korisnik castSesijuUKorisnika()
        {
            return (Korisnik)HttpContext.Current.Session["user"];
        }
    }
}