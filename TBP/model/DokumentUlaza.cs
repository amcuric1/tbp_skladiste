using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.model
{
    public class DokumentUlaza
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }
        public PoslovniPartner PoslovniPartner { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public List<StavkeDokumentaUlaza> Stavke { get; set; }

        public DokumentUlaza()
        {
            Stavke = new List<StavkeDokumentaUlaza>();
        }

    }
}
