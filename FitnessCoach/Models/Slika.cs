using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mongo.DataAccess;
using Mongo.Documents;

namespace FitnessCoach.Models
{
    public class Slika
    {
        public string ProfilnaToBase64(string ImeSlike)
        {
            byte[] imageByteData;
            if (ImeSlike == null)
            {
                imageByteData = System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath("~/Content/profilneSlike/") + "unknown-person.jpg");
            }
            else
            {
                imageByteData = System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath("~/Content/profilneSlike/") + ImeSlike);
            }
            string imageBase64Data = Convert.ToBase64String(imageByteData);
            string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);

            return imageDataURL;
        }

        public string VezbaToBase64(string SlikaVezbe, string MisicnaGrupa)
        {
            byte[] imageByteData;

            imageByteData = System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath("~/Content/slikeVezbi/") + MisicnaGrupa + "/" + SlikaVezbe);

            string imageBase64Data = Convert.ToBase64String(imageByteData);
            string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);

            return imageDataURL;
        }

        public string slika(Korisnik k)
        {
            return ProfilnaToBase64(k.Slika);
        }
    }
}