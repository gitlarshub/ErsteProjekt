using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung07
{
    public class Lebewesen
    {
        private DateTime Birthdate { get; set; }

        public Lebewesen(DateTime birthdate)
        {
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