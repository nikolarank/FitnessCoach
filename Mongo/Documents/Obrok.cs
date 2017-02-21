using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Mongo.Documents
{
    public class Obrok
    {
        public ObjectId Id { get; set; }
        public int Redni_Broj_Obroka { get; set; }
        public List<MongoDBRef> Namirnice { get; set; }
        public Obrok()
        {
            Namirnice = new List<MongoDBRef>();
        }
    }
}
