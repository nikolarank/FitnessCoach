using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo.Documents
{
    public class Korisnik
    {
        public ObjectId Id { get; set; }
        public string Ime { get; set; } //
        public string Prezime { get; set; } //
        public string Email { get; set; } //
        public string Korisnicko_Ime { get; set; } //
        public string Sifra { get; set; } //
        public string Slika { get; set; } //
        public string Biografija { get; set; }
        public double Rang { get; set; }
        public int Broj_Ocenjivanja { get; set; }
        public MongoDBRef Moj_Instruktor { get; set; }
        public bool Zahtev_Za_Instruktora { get; set; }
        public string Status { get; set; }
        public List<MongoDBRef> Treninzi { get; set; }
        public List<MongoDBRef> Planovi_Ishrane { get; set; }

        public Korisnik()
        {
            Treninzi = new List<MongoDBRef>();
            Planovi_Ishrane = new List<MongoDBRef>();
        }
    }
}
