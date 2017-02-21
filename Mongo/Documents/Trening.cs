using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo.Documents
{
    public class Trening
    {
        public ObjectId Id { get; set; }
        public string Naziv { get; set; }
        public float Prosecna_Ocena { get; set; }
        public int Broj_Ocenjivanja { get; set; }
        public string Misicna_Partija { get; set; }
        public List<MongoDBRef> Vezbe { get; set; }

        public Trening()
        {
            Vezbe = new List<MongoDBRef>();
        }
    }
}
