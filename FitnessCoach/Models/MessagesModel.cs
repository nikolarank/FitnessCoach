using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mongo;
using Mongo.DataAccess;
using Mongo.Documents;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FitnessCoach.Models
{
    public class MessagesModel:Slika
    {
        [DataType(DataType.MultilineText)]
        public string tekstPoruke { get; set; }

        public Korisnik KlijentUKonverzaciji { get; set; }
        public List<Korisnik> Klijenti { get; set; }

        public List<Poruka> PorukeInstruktorKlijent()
        {
            if (KlijentUKonverzaciji != null)
                return Poruke.VratiKonverzaciju((ObjectId)HttpContext.Current.Session["Id"], KlijentUKonverzaciji.Id);
            else
                return new List<Poruka>();
        }

        public Korisnik vratiPosiljaoca(ObjectId sender)
        {
            return Korisnici.Procitaj(sender);
        }

        public Korisnik vratiPosiljaoca(MongoDBRef sender)
        {
            return Connection<Korisnik>.getDatabase().FetchDBRefAs<Korisnik>(sender);
        }

        public MongoDBRef castInstruktoraUMongDBRef()
        {
            return (MongoDBRef)HttpContext.Current.Session["Instruktor"];
        }

        public List<Poruka> PorukeKlijentInstruktor()
        {
            if (HttpContext.Current.Session["Instruktor"] != null)
            {
                List<Poruka> lista = new List<Poruka>();
                ObjectId kuc1 = (ObjectId)HttpContext.Current.Session["Id"];
                MongoDBRef kuc2 = (MongoDBRef)HttpContext.Current.Session["Instruktor"];
                ObjectId a = Connection<Korisnik>.getDatabase().FetchDBRefAs<Korisnik>(kuc2).Id;
                lista = Poruke.VratiKonverzaciju(kuc1, a);
                return lista;
            }
            else
                return null;
        }

        public MessagesModel()
        {
            KlijentUKonverzaciji = new Korisnik();

            Klijenti = new List<Korisnik>();
            foreach (var ins in Korisnici.SviKlijenti((ObjectId)HttpContext.Current.Session["Id"]))
            {
                Klijenti.Add(ins);

            }
        }
    }
}