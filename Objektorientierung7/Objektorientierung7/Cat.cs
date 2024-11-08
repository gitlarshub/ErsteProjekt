using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Objektorientierung7
{
    public class Cat
    {
        private string? _Color = null;
        private DateTime _BirthDate;

        public string? Color
        {
            get { return _Color; }
            set
            {
                if (_Color == value) return;
                _Color = value;
            }
        }
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
        public Cat(DateTime birthdate)
        {
            _BirthDate = birthdate;
        }
    }


    public class Tierheim
    {
        private List<Cat> _cats;

        public Tierheim()
        {
            _cats = new List<Cat>();
        }
        public void AddCat(Cat cat)
        {
            _cats.Add(cat);
        }
        public List<Cat> GetAllCats()
        {
            return _cats;
        }
        public int GetCatCount()
        {
            return _cats.Count;
        }
        public void ListCatsByAge()

        {
            foreach (var cat in _cats)
            {
                Console.WriteLine($"Katze: Farbe = {cat.Color ?? "Unbekannt"}, Alter = {cat.Age} Jahre");
            }
        }
    }
}