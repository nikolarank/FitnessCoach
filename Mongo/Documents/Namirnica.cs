using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo.Documents
{
    public class Namirnica
    {
        public ObjectId Id { get; set; }
        public string Naziv { get; set; }
        public string Kalorije { get; set; }
        public string Proteini { get; set; }
        public string Uh { get; set; }
        public string Masti { get; set; }
    }
}
