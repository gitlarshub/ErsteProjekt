using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Objektorientierung07
{
    public class Cat : Animal
    {
        public string? Color { get; set; }
        public Cat(string name, DateTime birthdate) : base(name, birthdate)
        {
            Beine = 4; 
        }
        public override void GibTypischenLautVonDir()
        {
            Console.WriteLine($"{Name} sagt: Miau");
        }
    }
}
