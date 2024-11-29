using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung07
{
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
                Console.WriteLine($"Katze: Name = {cat.Name}, Farbe = {cat.Color}, Alter = {cat.Age} Jahre");
            }
        }
    }
}