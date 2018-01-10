using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBP.Database;
using TBP.klaseZaPrikaz;
using TBP.model;

namespace TBP
{
    public partial class frmDetaljiDokumentaIzlaza : Form
    {
        DokumentIzlaza dokumentIzlaza;

        public frmDetaljiDokumentaIzlaza(DokumentIzlaza prijenos)
        {
            InitializeComponent();
            dokumentIzlaza = prijenos;
        }

        private void frmDetaljiDokumentaIzlaza_Load(object sender, EventArgs e)
        {
            lblNaziv.Text = dokumentIzlaza.Naziv;
            lblDatum.Text = dokumentIzlaza.Datum.ToString();
            lblPrikazPP.Text = dokumentIzlaza.PoslovniPartner.Naziv;
            lblPrikazZ.Text = dokumentIzlaza.Zaposlenik.Prezime + " " + dokumentIzlaza.Zaposlenik.Ime;

            try
            {
                RadSBazom database = new RadSBazom();
                List<PrikazStavkiDokumentaIzlaza> listaPrikazaStavki = database.dohvatiStavkeDokumentaIzlazZaPrikazDetalja(dokumentIzlaza.Id);
                float ukupnaCijena = 0;

                for (int i = 0; i < listaPrikazaStavki.Count; i++)
                {
                    float iznos = 0;
                    iznos = listaPrikazaStavki[i].JedinicnaCijena * listaPrikazaStavki[i].Kolicina;

                    dgvStavkeDokumentaIzlaza.Rows.Add(listaPrikazaStavki[i].Naziv, listaPrikazaStavki[i].JedinicnaCijena + " kn", listaPrikazaStavki[i].Kolicina, iznos+" kn");
                    ukupnaCijena = ukupnaCijena + iznos;
                }
                lblUkupnaCijena.Text = ukupnaCijena.ToString()+ " kn";
            }
            catch (Exception)
            {
                MessageBox.Show("Došlo je do greške u radu s bazom!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
