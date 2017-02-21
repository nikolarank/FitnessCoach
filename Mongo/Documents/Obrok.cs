using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo.Documents
{
    public class Obrok
    {
        public ObjectId Id { get; set; }
        public int Redni_Broj_Obroka { get; set; }
    }
}
