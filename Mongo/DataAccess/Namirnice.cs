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
    public class Namirnice
    {
        private static string CollectionName = "namirnice";

        static public Namirnica Procitaj(ObjectId id)
        {
            Namirnica found = new Namirnica();

            try
            {
                var collection = Connection<Namirnica>.getCollection(CollectionName);
                return collection.FindOneByIdAs<Namirnica>(id);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default(Namirnica);
            }
        }

        static public List<Namirnica> SveNamirnice()
        {
            try
            {

                var collection = Connection<Namirnica>.getCollection(CollectionName);
                List<Namirnica> l = new List<Namirnica>();
                foreach (Namirnica Item in collection.FindAllAs<Namirnica>())
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

        public static void Dodaj(Namirnica Item)
        {
            try
            {
                var collection = Connection<Namirnica>.getCollection(CollectionName);
                if (Procitaj(Item.Id) == null)
                {
                    collection.Save(Item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
