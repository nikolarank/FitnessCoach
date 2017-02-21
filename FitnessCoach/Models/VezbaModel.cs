using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mongo.DataAccess;
using Mongo.Documents;

namespace FitnessCoach.Models
{
    public class VezbaModel:Slika
    {
        public bool Abdominals { get; set; }
        public bool Back { get; set; }
        public bool Biceps { get; set; }
        public bool Chest { get; set; }
        public bool Legs { get; set; }
        public bool Shoulders { get; set; }
        public bool Triceps { get; set; }
        public bool SelectAll { get; set; }

        public List<Vezba> vezbe(bool trbusnjaci, bool ledja, bool biceps, bool grudi, bool noge, bool ramena, bool triceps, bool sve)
        {
            return Vezbe.SelektovaniMisici(trbusnjaci, ledja, biceps, grudi, noge, ramena, triceps, sve);
        }
    }
}