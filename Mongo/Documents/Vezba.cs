using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;

namespace Mongo.Documents
{
    public class Vezba
    {
        public ObjectId Id { get; set; }
        public string Naziv { get; set; }
        public string Tekst { get; set; }
        public string Misicna_Partija { get; set; }
        public string Slika { get; set; }
        public double Prosecna_Ocena { get; set; }
        public int Broj_Ocenjivanja { get; set; }
    }
}
