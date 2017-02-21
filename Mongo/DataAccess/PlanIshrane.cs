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
    public class PlanIshrane
    {
        private static string CollectionName = "planovi_ishrane";


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
    }
}
