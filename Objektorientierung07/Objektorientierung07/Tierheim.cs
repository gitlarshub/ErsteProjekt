using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung07
{
    public class Tierheim
    {
        private List<Animal> _animals; // Alle Tiere werden hier gespeichert

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
        public void AddDog(Dog dog)
        {
            _animals.Add(dog);
        }
        public List<Animal> GetAllAnimals()
        {
            return _animals;
        }
        public int GetAnimalCount()
        {
            return _animals.Count;
        }
        public int GetCatCount()
        {
            return _animals.OfType<Cat>().Count();
        }
        public int GetDogCount()
        {
            return _animals.OfType<Dog>().Count();
        }
        public void ListCatsByAge()
        {
            var cats = _animals.OfType<Cat>();
            foreach (var cat in cats)
            {
                Console.WriteLine($"Katze: Name = {cat.Name}, Farbe = {cat.Color}, Alter = {cat.Age} Jahre");
            }
        }
    }

}