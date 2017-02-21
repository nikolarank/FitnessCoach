using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mongo.Documents;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace Mongo.DataAccess
{
    public class Poruke
    {
        public static void Dodaj(Poruka m)
        {
            MongoCollection<Poruka> porukeCollection = Connection<Poruka>.getCollection("poruke");
            porukeCollection.Insert(m);
        }

        public static Poruka Procitaj(ObjectId id)
        {
            MongoCollection<Poruka> porukeCollection = Connection<Poruka>.getCollection("poruke");
            Poruka poruka = (from p in porukeCollection.AsQueryable<Poruka>()
                             where p.Id == id
                             select p).FirstOrDefault();
            return poruka;
        }

        public static List<Poruka> VratiKonverzaciju(ObjectId kucadzija1, ObjectId kucadzija2)
        {
            List<Poruka> sve = new List<Poruka>();
            MongoCollection<Poruka> porukeCollection = Connection<Poruka>.getCollection("poruke");

            var find = from n in porukeCollection.AsQueryable<Poruka>()
                       orderby n.Vreme_Slanja ascending
                       where ((Korisnici.VratiObjId(n.Sender_ID) == kucadzija1 && Korisnici.VratiObjId(n.Receiver_ID) == kucadzija2) || (Korisnici.VratiObjId(n.Sender_ID) == kucadzija2 && Korisnici.VratiObjId(n.Receiver_ID) == kucadzija1))
                       select n.Id;
            foreach (var found in find)
            {
                sve.Add(Procitaj(found));
            }

            return sve;

        }
    }
}
