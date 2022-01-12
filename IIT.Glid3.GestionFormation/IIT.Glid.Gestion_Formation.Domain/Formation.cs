using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIT.Glid.Gestion_Formation.Domain
{
    public class Formation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        public string Sujet { get; set; }
        public DateTime Date { get; set; }
        public int Duree { get; set;  }
        public float Frais { get; set; }
        public Formateur Formateur { get; set; }
        public List<Etudiant> Etudiants { get; set; }

    }
}
