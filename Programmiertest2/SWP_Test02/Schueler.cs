using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Test02
{
    public class Schueler : Person
    {
        public string Schulklasse { get; set; }

        public Schueler(string name, string geschlecht, DateTime geburtsdatum, string schulklasse) : base(name, geschlecht, geburtsdatum)
        {
            Schulklasse = schulklasse;
        }
    }
}