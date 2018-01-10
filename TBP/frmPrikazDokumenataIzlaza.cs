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
using TBP.model;

namespace TBP
{
    public partial class frmPrikazDokumenataIzlaza : Form
    {
        Panel glavni;

        public frmPrikazDokumenataIzlaza(Panel panel)
        {
            InitializeComponent();
            glavni = panel;
            dohvatiSveDokumente();
        }

        private void frmPrikazDokumenataIzlaza_Load(object sender, EventArgs e)
        {
            this.Parent = glavni;
        }

        private void bojanje(object sender, EventArgs e)
        {
            Button gumb = sender as Button;
            gumb.BackColor = Color.Crimson;
        }

        private void micanjeBoje(object sender, EventArgs e)
        {
            Button gumb = sender as Button;
            gumb.BackColor = Color.Silver;
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            try
            {
                frmDetaljiDokumentaIzlaza frmDetaljiDokumentaIzlaza = new frmDetaljiDokumentaIzlaza(dohvatiOdabraniDokumentZaPrikaz());
                frmDetaljiDokumentaIzlaza.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ne postoji niti jedan dokument!!",
                    "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DokumentIzlaza dohvatiOdabraniDokumentZaPrikaz()
        {
            DokumentIzlaza du = new DokumentIzlaza();
            int id = int.Parse(dgvDokumentiIzlaza.CurrentRow.Cells[0].Value.ToString());
            RadSBazom database = new RadSBazom();
            du = database.dohvatiOdabraniDokumentIzlazaZaPrikaz(id);
            return du;
        }

        private void btnDodajDokument_Click(object sender, EventArgs e)
        {
            frmDokumentIzlaza frmdokumentIzlaza = new frmDokumentIzlaza();
            if (frmdokumentIzlaza.ShowDialog() == DialogResult.OK)
            {
                dohvatiSveDokumente();
            }
        }



        private void dohvatiSveDokumente()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<DokumentIzlaza> listaDokumenataIzlaza = database.dohvatiSveDokumenteIzlaza();
                dgvDokumentiIzlaza.Rows.Clear();
                for (int i = 0; i < listaDokumenataIzlaza.Count; i++)
                {
                    dgvDokumentiIzlaza.Rows.Add(listaDokumenataIzlaza[i].Id, listaDokumenataIzlaza[i].Naziv,
                        listaDokumenataIzlaza[i].Datum, listaDokumenataIzlaza[i].Zaposlenik.Id,
                        listaDokumenataIzlaza[i].Zaposlenik.Prezime + " " + listaDokumenataIzlaza[i].Zaposlenik.Ime,
                        listaDokumenataIzlaza[i].PoslovniPartner.Id, listaDokumenataIzlaza[i].PoslovniPartner.Naziv);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pokušajte osvježiti podatke klikom na gumb 'Dokumenti izlaza' jer spajanje s bazom podataka nije uspjelo.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
