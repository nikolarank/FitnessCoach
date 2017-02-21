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
    public class Treninzi
    {
        public static Trening Procitaj(ObjectId id)
        {
            MongoCollection<Trening> treninziCollection = Connection<Trening>.getCollection("treninzi");
            Trening trening = (from t in treninziCollection.AsQueryable<Trening>()
                               where t.Id == id
                               select t).FirstOrDefault();
            return trening;
        }

        public static List<Trening> SviTreninzi()
        {
            MongoCollection<Trening> treninziCollection = Connection<Trening>.getCollection("treninzi");
            MongoCursor<Trening> treninzi = treninziCollection.FindAll();
            return treninzi.ToList<Trening>();
        }

        public static void AddToList(MongoCollection<Trening> treninziCollection, string misicnaPartija, List<Trening> lista)
        {
            var find = from t in treninziCollection.AsQueryable<Trening>()
                       where t.Misicna_Partija == misicnaPartija
                       select t.Id;
            foreach (var found in find)
            {
                lista.Add(Procitaj(found));
            }
        }

        public static List<Trening> SelektovaniMisici(bool trbusnjaci, bool ledja, bool biceps, bool grudi, bool noge, bool ramena, bool triceps, bool sve)
        {
            List<Trening> Sve = new List<Trening>();
            MongoCollection<Trening> treninziCollection = Connection<Trening>.getCollection("treninzi");

            if (sve == true)
                return SviTreninzi();
            else
            {
                if (trbusnjaci == true) AddToList(treninziCollection, "abs", Sve);
                if (ledja == true) AddToList(treninziCollection, "back", Sve);
                if (biceps == true) AddToList(treninziCollection, "biceps", Sve);
                if (grudi == true) AddToList(treninziCollection, "chest", Sve);
                if (noge == true) AddToList(treninziCollection, "legs", Sve);
                if (ramena == true) AddToList(treninziCollection, "shoulders", Sve);
                if (triceps == true) AddToList(treninziCollection, "triceps", Sve);
            }

            return Sve;
        }

        public static List<Vezba> SveVezbeUTreningu(ObjectId treningID)
        {
            List<Vezba> sve = new List<Vezba>();
            MongoCollection<Trening> treninziCollection = Connection<Trening>.getCollection("treninzi");

            foreach (MongoDBRef vezbaRef in Procitaj(treningID).Vezbe.ToList())
            {
                sve.Add(Connection<Trening>.getDatabase().FetchDBRefAs<Vezba>(vezbaRef));
            }

            return sve;
        }

        public static void Dodaj(Trening Item)
        {
            try
            {
                var collection = Connection<Trening>.getCollection("treninzi");
                collection.Insert(Item);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
