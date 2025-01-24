using System;
using System.Collections.Generic;

namespace SWP_Test02
{
    public class Schule
    {
        private List<Schueler> _schuelerListe { get; set; } = new List<Schueler>();
        private List<Klassenraum> _klassenraume { get; set; } = new List<Klassenraum>();
        public void AddSchüler(Schueler schüler) 
        { 
            _schuelerListe.Add(schüler); 
        }
        public void AddKlassenraum(Klassenraum klassenraum) 
        {
            _klassenraume.Add(klassenraum);
        }
        public int GetAnzahlSchüler()
        { 
            return _schuelerListe.Count(); 
        }
        public int GetAnzahlSchülerNachGeschlecht(string geschlecht) 
        {
            int count = 0;
            foreach (var schüler in _schuelerListe)
            {
                if (string.Equals(schüler.Geschlecht, geschlecht, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            return count;
        }
        public int GetAnzahlKlassenräume() 
        { 
            return _klassenraume.Count(); 
        }
        public double GetDurchschnittsalter()
        {
            if (_schuelerListe.Count == 0) return 0;

            double summeAlter = 0;
            foreach (var schüler in _schuelerListe)
            {
                summeAlter += (DateTime.Now - schüler.Geburtsdatum).TotalDays / 365.25;
            }
            return Math.Round(summeAlter / _schuelerListe.Count, 2);
        }
        public List<Klassenraum> GetRäumeMitCynap()
        {
            List<Klassenraum> räumeMitCynap = new List<Klassenraum>();
            foreach (var raum in _klassenraume)
            {
                if (raum.HatCynap)
                {
                    räumeMitCynap.Add(raum);
                }
            }
            return räumeMitCynap;
        }
        public int GetAnzahlKlassen()
        {
            HashSet<string> klassenSet = new HashSet<string>();
            foreach (var schüler in _schuelerListe)
            {
                klassenSet.Add(schüler.Schulklasse);
            }
            return klassenSet.Count;
        }
        public Dictionary<string, int> GetKlassenMitAnzahlSchüler()
        {
            Dictionary<string, int> klassenSchülerZahl = new Dictionary<string, int>();
            foreach (var schüler in _schuelerListe)
            {
                if (klassenSchülerZahl.ContainsKey(schüler.Schulklasse))
                {
                    klassenSchülerZahl[schüler.Schulklasse]++;
                }
                else
                {
                    klassenSchülerZahl[schüler.Schulklasse] = 1;
                }
            }
            return klassenSchülerZahl;
        }
        public double GetFrauenanteil(string schulklasse)
        {
            List<Schueler> schülerInKlasse = new List<Schueler>();
            foreach (var schüler in _schuelerListe)
            {
                if (schüler.Schulklasse == schulklasse)
                {
                    schülerInKlasse.Add(schüler);
                }
            }
            if (schülerInKlasse.Count == 0) return 0;

            double frauen = 0;
            foreach (var schüler in schülerInKlasse)
            {
                if (schüler.Geschlecht == "Weiblich")
                {
                    frauen++;
                }
            }
            return Math.Round((frauen / schülerInKlasse.Count) * 100, 2);
        }
        public bool KannKlasseRaumNutzen(string schulklasse, string raumId)
        {
            int schülerAnzahl = 0;
            foreach (var schüler in _schuelerListe)
            {
                if (schüler.Schulklasse == schulklasse)
                {
                    schülerAnzahl++;
                }
            }

            foreach (var raum in _klassenraume)
            {
                if (raum.RaumId == raumId)
                {
                    return schülerAnzahl <= raum.Plaetze;
                }
            }
            return false;
        }
    }
}
