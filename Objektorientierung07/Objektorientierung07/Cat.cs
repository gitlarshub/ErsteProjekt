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
        private DateTime _BirthDate;
        public string? Color { get; set; }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - _BirthDate.Year;
                if (_BirthDate > today.AddYears(-age)) age--;
                return age;
            }
        }
        public Cat(string name, DateTime birthdate) : base(name)
        {
            _BirthDate = birthdate;
        }
        public Cat(DateTime birthdate) : base("Unknown")
        {
            _BirthDate = birthdate;
        }
    }
}

