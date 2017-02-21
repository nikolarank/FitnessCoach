using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mongo.DataAccess;
using Mongo.Documents;

namespace FitnessCoach.Models
{
    public class NamirnicaModel
    {
        public List<Namirnica> namirnice { get; set; }

        public NamirnicaModel()
        {
            namirnice = new List<Namirnica>();
            foreach (var ins in Namirnice.SveNamirnice())
            {
                namirnice.Add(ins);
            }
        }
    }
}