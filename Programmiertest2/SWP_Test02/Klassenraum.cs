using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Test02
{
    public class Klassenraum
    {
        public string RaumId { get; set; }
        public int Groeße { get; set; }
        public int Plaetze { get; }
        public bool HatCynap { get; set; }

        public Klassenraum(string raumId, int größe, int plätze, bool hatCynap)
        {
            RaumId = raumId;
            Groeße = größe;
            Plaetze = plätze;
            HatCynap = hatCynap;
        }
    }
}