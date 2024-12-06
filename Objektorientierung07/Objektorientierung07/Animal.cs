using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung07
{
    public class Animal : Lebewesen
    {
        public int Beine { get; set; }

        public Animal(string name, DateTime geburtsdatum) : base(name, geburtsdatum)
        {
        }
        public virtual void GibTypischenLautVonDir()
        {
            Console.WriteLine("Ein typischer Laut eines generischen Tieres.");
        }
    }
}


