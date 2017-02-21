using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace Mongo
{
    public static class Connection<T>
    {
        public static MongoDatabase getDatabase()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fitness");
            return db;
        }

        public static MongoCollection<T> getCollection(string name)
        {
            var collection = getDatabase().GetCollection<T>(name);
            return collection;

            //_client = new MongoClient();
            //_database = _client.GetDatabase("proba");
            //_database.GetCollection<BsonDocument>(name);
        }
    }
}
