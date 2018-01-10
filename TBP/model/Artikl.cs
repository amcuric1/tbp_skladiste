using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.model
{
    public class Artikl
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public float JedinicnaCijena { get; set; }
        public int KolicinaNaSkladistu { get; set; }
        public int MinimalnaKolicinaNaSkladistu { get; set; }
        public JedinicaMjereArtikla JedinicaMjere { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
