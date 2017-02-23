using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mongo.Documents;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Mongo.DataAccess
{
    public class Korisnici
    {
        private static string CollectionName = "korisnici";

        public static void Dodaj(Korisnik Item)
        {
            try
            {
                var collection = Connection<Korisnik>.getCollection(CollectionName);
                if (ProcitajPoMailu(Item.Email) == null)
                {
                    collection.Save(Item); 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public Korisnik Procitaj(ObjectId id)
        {
            Korisnik found = new Korisnik();

            try
            {
                var collection = Connection<Korisnik>.getCollection(CollectionName);
                return collection.FindOneByIdAs<Korisnik>(id);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default(Korisnik);
            }
        }

        static public Korisnik Procitaj(string username)
        {
            try
            {
                var collection = Connection<Korisnik>.getCollection(CollectionName);
                var query = Query.EQ("Korisnicko_Ime", username);

                return collection.Find(query).SingleOrDefault();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default(Korisnik);
            }
        }

        static public Korisnik ProcitajPoMailu(string email)
        {
            try
            {
                var collection = Connection<Korisnik>.getCollection(CollectionName);
                var query = Query.EQ("Email", email);

                return collection.Find(query).SingleOrDefault();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default(Korisnik);
            }
        }

        static public void PromeniSifru(Korisnik k, string sifra)
        {
            try
            {
                k.Sifra = sifra;
                var collection = Connection<Korisnik>.getCollection(CollectionName);

                //var query = Query.EQ("Email", k.Email);
                //var update = Update.Set("Sifra", BsonValue.Create(k.Sifra));

                //collection.Update(query, update);

                collection.Save(k);


            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public List<Korisnik> SviKorisnici()
        {
            try
            {

                var collection = Connection<Korisnik>.getCollection(CollectionName);
                List<Korisnik> l = new List<Korisnik>();
                foreach (Korisnik Item in collection.FindAllAs<Korisnik>())
                {
                    l.Add(Item);
                }
                return l;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }

        static public List<Korisnik> SviInstruktori()
        {
            List<Korisnik> svi = new List<Korisnik>();

            try
            {
                var collection = Connection<Korisnik>.getCollection(CollectionName);

                var find = from n in collection.AsQueryable<Korisnik>()
                           where (n.Status == "fitnes_instruktor")
                           select n;

                foreach (var found in find)
                {
                    svi.Add(found);
                }
                return svi;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return svi;
        }

        static public void PromeniInstruktora(ObjectId korisnikID, ObjectId instruktorId)
        {

            try
            {
                var collection = Connection<Korisnik>.getCollection(CollectionName);

                Korisnik k = Korisnici.Procitaj(korisnikID);

                k.Moj_Instruktor = new MongoDBRef(CollectionName, instruktorId);

                collection.Save(k);

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public List<Korisnik> SviKlijenti(ObjectId instruktorId)
        {
            List<Korisnik> svi = new List<Korisnik>();

            try
            {
                var collection = Connection<Korisnik>.getCollection(CollectionName);

                var find = from n in collection.AsQueryable<Korisnik>()
                           where (n.Moj_Instruktor.Id == instruktorId)
                           select n;

                foreach (var found in find)
                {
                    svi.Add(found);
                }
                return svi;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return svi;
        }

        static public void KonvertujUInstruktora(ObjectId id)
        {
            try
            {
                Korisnik k = Korisnici.Procitaj(id);
                k.Status = "fitnes_instruktor";
                k.Moj_Instruktor = null;
                k.Zahtev_Za_Instruktora = false;

                var collection = Connection<Korisnik>.getCollection(CollectionName);

                collection.Save(k);

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void KonvertujUKorisnika(ObjectId id)
        {
            try
            {
                Korisnik k = Korisnici.Procitaj(id);
                k.Status = "korisnik";

                var collection = Connection<Korisnik>.getCollection(CollectionName);

                collection.Save(k);

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void OdbijZahtevZaInstruktora(ObjectId id)
        {
            try
            {
                Korisnik k = Korisnici.Procitaj(id);
                k.Zahtev_Za_Instruktora = false;

                var collection = Connection<Korisnik>.getCollection(CollectionName);

                collection.Save(k);

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void ObrisiKorisnika(ObjectId id)
        {
            try
            {
                var collection = Connection<Korisnik>.getCollection(CollectionName);
                var query = Query.EQ("_id", id);
                collection.Remove(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void PromeniSliku(ObjectId id, string ImeSlike)
        {
            try
            {
                Korisnik k = Korisnici.Procitaj(id);
                k.Slika = ImeSlike;

                var collection = Connection<Korisnik>.getCollection(CollectionName);

                collection.Save(k);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void PostaniInstruktor(ObjectId korisnikID)
        {
            try
            {
                Korisnik k = new Korisnik();
                k = Korisnici.Procitaj(korisnikID);
                k.Zahtev_Za_Instruktora = true;

                var collection = Connection<Korisnik>.getCollection(CollectionName);

                collection.Save(k);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void PromeniBiografiju(Korisnik k, string biogr)
        {
            try
            {
                k.Biografija = biogr;

                var collection = Connection<Korisnik>.getCollection(CollectionName);

                collection.Save(k);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void DodajTrening(ObjectId korisnikID, ObjectId treningID)
        {
            try
            {
                Korisnik k = Korisnici.Procitaj(korisnikID);
                k.Treninzi.Add(new MongoDBRef("treninzi", treningID));
                var collection = Connection<Korisnik>.getCollection(CollectionName);

                collection.Save(k);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void DodajPlanIshrane(ObjectId korisnikID, ObjectId planID)
        {
            try
            {
                Korisnik k = Korisnici.Procitaj(korisnikID);
                k.Planovi_Ishrane.Add(new MongoDBRef("planovi_ishrane", planID));
                var collection = Connection<Korisnik>.getCollection(CollectionName);

                collection.Save(k);

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static List<Trening> SviTreninziKorisnika(ObjectId korisnikID)
        {
            List<Trening> sve = new List<Trening>();

            foreach (MongoDBRef treningRef in Procitaj(korisnikID).Treninzi)
            {
                sve.Add(Connection<Trening>.getDatabase().FetchDBRefAs<Trening>(treningRef));
            }

            return sve;
        }

        public static List<Plan_Ishrane> SviPlanoviKorisnika(ObjectId korisnikID)
        {
            List<Plan_Ishrane> sve = new List<Plan_Ishrane>();

            foreach (MongoDBRef planRef in Procitaj(korisnikID).Planovi_Ishrane)
            {
                sve.Add(Connection<Plan_Ishrane>.getDatabase().FetchDBRefAs<Plan_Ishrane>(planRef));
            }

            return sve;
        }

        public static ObjectId VratiObjId(MongoDBRef referenca)
        {
            return Connection<Korisnik>.getDatabase().FetchDBRefAs<Korisnik>(referenca).Id;
        }
    }
}
