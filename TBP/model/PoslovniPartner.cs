using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.model
{
    public class PoslovniPartner
    {
        public int Id { get; set; }
        public string OIB { get; set; }
        public string Naziv { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public string Adresa { get; set; }
        public Grad Grad { get; set; }
        public DateTime DatumPocetkaPartnerstva { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
