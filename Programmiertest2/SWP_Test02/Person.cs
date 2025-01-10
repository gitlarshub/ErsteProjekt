using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Test02
{
    public class Person
    {
        public string Name { get; private set; }
        public string Geschlecht { get; }
        public DateTime Geburtsdatum { get; }

        public Person(string name, string geschlecht, DateTime geburtsdatum)
        {
            Name = name;
            Geschlecht = geschlecht;
            Geburtsdatum = geburtsdatum;
        }
    }
}