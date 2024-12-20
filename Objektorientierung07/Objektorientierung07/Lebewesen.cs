﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung07
{
    public class Lebewesen
    {
        public string Name { get; set; }
        private DateTime Birthdate { get; }
        public Lebewesen(string name, DateTime birthdate, string? color = null)
        {
            Name = name;
            Birthdate = birthdate;
        }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - Birthdate.Year;
                if (Birthdate > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}


