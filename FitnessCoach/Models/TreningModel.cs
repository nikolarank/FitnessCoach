using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mongo.DataAccess;
using Mongo.Documents;
using MongoDB.Bson;
using System.Web.Mvc;

namespace FitnessCoach.Models
{
    public class TreningModel:Slika
    {
        public bool Abdominals { get; set; }
        public bool Back { get; set; }
        public bool Biceps { get; set; }
        public bool Chest { get; set; }
        public bool Legs { get; set; }
        public bool Shoulders { get; set; }
        public bool Triceps { get; set; }
        public bool SelectAll { get; set; }

        public List<Trening> PlanoviTreningaKorisnika { get; set; }

        public List<Trening> treninzi(bool trbusnjaci, bool ledja, bool biceps, bool grudi, bool noge, bool ramena, bool triceps, bool sve)
        {
            return Treninzi.SelektovaniMisici(trbusnjaci, ledja, biceps, grudi, noge, ramena, triceps, sve);
        }

        public List<Vezba> VezbeUTreningu(ObjectId treningID)
        {
            return Treninzi.SveVezbeUTreningu(treningID);
        }

        public List<SelectListItem> SveVezbe()
        {
            List<SelectListItem> listItems = new List<SelectListItem>();
            foreach (Vezba v in Vezbe.SveVezbe())
            {
                listItems.Add(new SelectListItem
                {
                    Text = v.Naziv,
                    Value = v.Id.ToString()
                });
            }

            return listItems;
        }

        public TreningModel()
        {
            PlanoviTreningaKorisnika = new List<Trening>();
            foreach (var ins in Korisnici.SviTreninziKorisnika((ObjectId)HttpContext.Current.Session["Id"]))
            {
                PlanoviTreningaKorisnika.Add(ins);
            }
        }

    }
}