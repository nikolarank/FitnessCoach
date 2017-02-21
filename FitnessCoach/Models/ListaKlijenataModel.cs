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
    public class ListaKlijenataModel:Slika
    {
        public List<Korisnik> Klijenti { get; set; }

        public ListaKlijenataModel()
        {
            Klijenti = new List<Korisnik>();
            foreach (var ins in Korisnici.SviKlijenti((ObjectId)HttpContext.Current.Session["Id"]))
            {
                Klijenti.Add(ins);
            }
        }

    }
}