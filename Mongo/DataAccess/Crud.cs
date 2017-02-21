using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongo.Documents;
using MongoDB.Driver.Builders;

namespace Mongo.DataAccess
{
    public class Crud<T>
    {
        public static void Create(string name, T Item)
        {
            try
            {
                var collection = Connection<T>.getCollection(name);
                collection.Insert(Item);

            }
            catch (Exception e)
            {
            }
        }

        static public T Read(string name, int id)
        {
            try
            {
                var collection = Connection<T>.getCollection(name);
                return collection.FindOneByIdAs<T>(id);

            }
            catch (Exception e)
            {
                return default(T);
            }

        }



        public static List<T> ReturnAll(string name)
        {
            try
            {

                var collection = Connection<T>.getCollection(name);
                List<T> l = new List<T>();
                foreach (T Item in collection.FindAllAs<T>())
                {
                    l.Add(Item);
                }
                return l;

            }
            catch (Exception e)
            {

                return null;
            }
        }
    }
}
