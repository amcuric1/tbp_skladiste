using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.model
{
    public class Zaposlenik
    {
        public int Id { get; set; }
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public string Adresa { get; set; }
        public Grad Grad { get; set; }
        public DateTime DatumZaposlenja { get; set; }

        public override string ToString()
        {
            return Prezime+" "+Ime;
        }
    }
}
