using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mongo.Documents;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace Mongo.DataAccess
{
    public class Vezbe
    {
        public static Vezba Procitaj(ObjectId id)
        {
            MongoCollection<Vezba> vezbeCollection = Connection<Vezba>.getCollection("vezbe");
            Vezba vezba = (from v in vezbeCollection.AsQueryable<Vezba>()
                           where v.Id == id
                           select v).FirstOrDefault();
            return vezba;
        }

        public static List<Vezba> SveVezbe()
        {
            MongoCollection<Vezba> vezbeCollection = Connection<Vezba>.getCollection("vezbe");
            MongoCursor<Vezba> vezbe = vezbeCollection.FindAll();
            return vezbe.ToList<Vezba>();
        }

        public static void AddToList(MongoCollection<Vezba> vezbeCollection, string misicnaPartija, List<Vezba> lista)
        {
            var find = from v in vezbeCollection.AsQueryable<Vezba>()
                       where v.Misicna_Partija == misicnaPartija
                       select v.Id;
            foreach (var found in find)
            {
                lista.Add(Procitaj(found));
            }
        }

        public static List<Vezba> SelektovaniMisici(bool trbusnjaci, bool ledja, bool biceps, bool grudi, bool noge, bool ramena, bool triceps, bool sve)
        {
            List<Vezba> Sve = new List<Vezba>();
            MongoCollection<Vezba> vezbeCollection = Connection<Vezba>.getCollection("vezbe");

            if (sve == true)
                return SveVezbe();
            else
            {
                if (trbusnjaci == true) AddToList(vezbeCollection, "abs", Sve);
                if (ledja == true) AddToList(vezbeCollection, "back", Sve);
                if (biceps == true) AddToList(vezbeCollection, "biceps", Sve);
                if (grudi == true) AddToList(vezbeCollection, "chest", Sve);
                if (noge == true) AddToList(vezbeCollection, "legs", Sve);
                if (ramena == true) AddToList(vezbeCollection, "shoulders", Sve);
                if (triceps == true) AddToList(vezbeCollection, "triceps", Sve);
            }

            return Sve;
        }

        public static void Dodaj(Vezba Item)
        {
            try
            {
                var collection = Connection<Vezba>.getCollection("vezbe");
                collection.Insert(Item);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
