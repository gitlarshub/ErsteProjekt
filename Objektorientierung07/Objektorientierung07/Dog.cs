using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung07
{
    public class Dog : Animal
    {
        public Dog(string name, DateTime birthdate) : base(name, birthdate)
        {
            Beine = 4;
        }
        public override void GibTypischenLautVonDir()
        {
            Console.WriteLine($"{Name} sagt: Wuff");
        }
    }
}
