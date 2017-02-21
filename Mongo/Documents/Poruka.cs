using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo.Documents
{
    public class Poruka
    {
        public ObjectId Id { get; set; }
        public System.DateTime Vreme_Slanja { get; set; }
        public string Tekst { get; set; }
        public bool Procitana { get; set; }
        public MongoDBRef Sender_ID { get; set; }
        public MongoDBRef Receiver_ID { get; set; }
    }
}
