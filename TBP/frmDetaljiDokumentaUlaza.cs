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
    public partial class frmDetaljiDokumentaUlaza : Form
    {
        DokumentUlaza dokumentUlaza;

        public frmDetaljiDokumentaUlaza(DokumentUlaza prijenos)
        {
            InitializeComponent();
            dokumentUlaza = prijenos;
        }

        private void frmDetaljiDokumentaUlaza_Load(object sender, EventArgs e)
        {
            lblNaziv.Text = dokumentUlaza.Naziv;
            lblDatum.Text = dokumentUlaza.Datum.ToString();
            lblPrikazPP.Text = dokumentUlaza.PoslovniPartner.Naziv;
            lblPrikazZ.Text = dokumentUlaza.Zaposlenik.Prezime +" "+ dokumentUlaza.Zaposlenik.Ime;

            try
            {
                RadSBazom database = new RadSBazom();
                List<PrikazStavkiDokumentaUlaza> listaPrikazaStavki = database.dohvatiStavkeDokumentaUlazZaPrikazDetalja(dokumentUlaza.Id);
                float ukupnaCijena = 0;

                for (int i = 0; i < listaPrikazaStavki.Count; i++)
                {
                    float iznos = 0;
                    iznos = listaPrikazaStavki[i].JedinicnaCijena * listaPrikazaStavki[i].Kolicina;

                    dgvStavkeDokumentaUlaza.Rows.Add(listaPrikazaStavki[i].Naziv, listaPrikazaStavki[i].JedinicnaCijena+" kn", listaPrikazaStavki[i].Kolicina, iznos+" kn");
                    ukupnaCijena = ukupnaCijena + iznos;
                }
                lblUkupnaCijena.Text = ukupnaCijena.ToString() + " kn";
            }
            catch (Exception)
            {
                MessageBox.Show("Došlo je do greške u radu s bazom!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
