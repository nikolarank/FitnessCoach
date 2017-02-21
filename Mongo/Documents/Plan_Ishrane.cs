using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;


namespace Mongo.Documents
{
    public class Plan_Ishrane
    {
        public ObjectId Id { get; set; }
        public string Naziv { get; set; }
        public double Prosecna_Ocena { get; set; }
        public int Broj_Ocenjivanja { get; set; }
        public List<MongoDBRef> Obroci { get; set; }

        public Plan_Ishrane()
        {
            Obroci = new List<MongoDBRef>();
        }
    }
}
