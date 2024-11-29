using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung07
{
    public class Animal : Lebewesen
    {
        public string Name { get; }

        public Animal(string name, DateTime birthdate) : base(birthdate)
        {
            Name = name;
        }
    }
}

