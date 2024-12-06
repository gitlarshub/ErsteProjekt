using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung07
{
    public class Tierheim
    {
        private List<Animal> _animals;

        public Tierheim()
        {
            _animals = new List<Animal>();
        }
        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }
        public void AddCat(Cat cat)
        {
            _animals.Add(cat);
        }
        public int GetAnimalCount()
        {
            return _animals.Count;
        }
        public int GetCatCount()
        {
            return _animals.OfType<Cat>().Count();
        }
        public void ListCatsByAge()
        {
            foreach (var cat in _animals.OfType<Cat>())
            {
                Console.WriteLine($"Katze: Name = {cat.Name}, Farbe = {cat.Color}, Alter = {cat.Age} Jahre");
            }
        }
    }
}