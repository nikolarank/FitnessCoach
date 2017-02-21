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
    public static class PlanIshrane
    {
        private static string CollectionName = "planovi_ishrane";

        public static void Dodaj(Plan_Ishrane Item)
        {
            try
            {
                var collection = Connection<Plan_Ishrane>.getCollection(CollectionName);
                collection.Save(Item); ;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public Plan_Ishrane Procitaj(ObjectId id)
        {
            Plan_Ishrane found = new Plan_Ishrane();

            try
            {
                var collection = Connection<Plan_Ishrane>.getCollection(CollectionName);
                return collection.FindOneByIdAs<Plan_Ishrane>(id);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default(Plan_Ishrane);
            }
        }

        static public List<Plan_Ishrane> SviPlanovi()
        {
            try
            {

                var collection = Connection<Plan_Ishrane>.getCollection(CollectionName);
                List<Plan_Ishrane> l = new List<Plan_Ishrane>();
                foreach (Plan_Ishrane Item in collection.FindAllAs<Plan_Ishrane>())
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

        static public void DodajObrok(ObjectId planId, MongoDBRef obrok)
        {
            try
            {
                var collection = Connection<Plan_Ishrane>.getCollection(CollectionName);

                Plan_Ishrane k = PlanIshrane.Procitaj(planId);

                k.Obroci.Add(obrok);

                collection.Save(k);

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void ObrisiObrok(ObjectId planId, MongoDBRef obrok)
        {

            try
            {
                var collection = Connection<Obrok>.getCollection(CollectionName);

                Obrok k = Obroci.Procitaj(planId);

                k.Namirnice.Remove(obrok);

                collection.Save(k);

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
