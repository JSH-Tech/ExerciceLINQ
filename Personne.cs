using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceLINQ
{
    public enum Sexe
    {
        Homme,
        Femme
    }
    internal class Personne
    {
        public string Nom { get; set; } = "";
        public string Prenom { get; set; } = "";
        public DateTime? DateNaissance { get; set; }
        public int TailleCm { get; set; }
        public Sexe Sexe { get; set; }
    }
}
