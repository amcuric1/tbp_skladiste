using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.model
{
    public class JedinicaMjereArtikla
    {
        public int Id { get; set; }
        public String Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
