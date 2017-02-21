using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mongo.DataAccess;
using Mongo.Documents;
using MongoDB.Bson;
using Mongo;
using MongoDB.Driver;

namespace FitnessCoach.Models
{
    public class ListaInstruktoraModel:Slika
    {
        public List<Korisnik> Instruktori { get; set; }

        public ObjectId VratiObjectIdInstruktora()
        {
            return Connection<Korisnik>.getDatabase().FetchDBRefAs<Korisnik>((MongoDBRef)HttpContext.Current.Session["Instruktor"]).Id;
        }

        public ListaInstruktoraModel()
        {
            Instruktori = new List<Korisnik>();
            foreach (var ins in Korisnici.SviInstruktori())
            {
                Instruktori.Add(ins);

            }
        }
    }

}