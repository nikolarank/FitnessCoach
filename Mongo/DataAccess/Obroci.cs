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
    public class Obroci
    {
        private static string CollectionName = "obroci";

        public static void Dodaj(Obrok Item)
        {
            try
            {
                var collection = Connection<Obrok>.getCollection(CollectionName);
                collection.Save(Item); ;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public Obrok Procitaj(ObjectId id)
        {
            Obrok found = new Obrok();

            try
            {
                var collection = Connection<Obrok>.getCollection(CollectionName);
                return collection.FindOneByIdAs<Obrok>(id);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default(Obrok);
            }
        }

        static public void PromeniRedniBroj(ObjectId ObrokID, int broj)
        {

            try
            {
                var collection = Connection<Obrok>.getCollection(CollectionName);

                Obrok k = Obroci.Procitaj(ObrokID);

                k.Redni_Broj_Obroka = broj;

                collection.Save(k);

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void DodajNamirnicu(ObjectId ObrokID, MongoDBRef nam)
        {

            try
            {
                var collection = Connection<Obrok>.getCollection(CollectionName);

                Obrok k = Obroci.Procitaj(ObrokID);

                k.Namirnice.Add(nam);

                collection.Save(k);

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void ObrisiNamirnicu(ObjectId ObrokID, MongoDBRef nam)
        {

            try
            {
                var collection = Connection<Obrok>.getCollection(CollectionName);

                Obrok k = Obroci.Procitaj(ObrokID);

                k.Namirnice.Remove(nam);

                collection.Save(k);

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
