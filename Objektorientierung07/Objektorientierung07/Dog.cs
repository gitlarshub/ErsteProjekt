﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung07
{
    public class Dog : Animal
    {
        public string? Color { get; set; }
        public Dog(string name, string color, DateTime birthdate) : base(name, birthdate)
        {
            Color = color;
            Beine = 4;
        }
        public override void GibTypischenLautVonDir()
        {
            Console.WriteLine($"{Name} sagt: Wuff");
        }
    }
}
