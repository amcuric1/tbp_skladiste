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
    public partial class frmPrikazDokumenataUlaza : Form
    {
        Panel glavni;

        public frmPrikazDokumenataUlaza(Panel panel)
        {
            InitializeComponent();
            glavni = panel;
            dohvatiSveDokumente();
        }

        private void frmPrikazDokumenataUlaza_Load(object sender, EventArgs e)
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
                frmDetaljiDokumentaUlaza frmDetaljiDokumentaUlaza = new frmDetaljiDokumentaUlaza(dohvatiOdabraniDokumentZaPrikazDetalja());
                frmDetaljiDokumentaUlaza.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ne postoji niti jedan dokument!!",
                    "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DokumentUlaza dohvatiOdabraniDokumentZaPrikazDetalja()
        {
            DokumentUlaza du = new DokumentUlaza();
            int id = int.Parse(dgvDokumentiUlaza.CurrentRow.Cells[0].Value.ToString());
            RadSBazom database = new RadSBazom();
            du = database.dohvatiOdabraniDokumentZaPrikaz(id);
            return du;
        }

        private void btnDodajDokument_Click(object sender, EventArgs e)
        {
            frmDokumentUlaza frmDokumentUlaza = new frmDokumentUlaza();
            if(frmDokumentUlaza.ShowDialog() == DialogResult.OK)
            {
                dohvatiSveDokumente();
            }
        }


        private void dohvatiSveDokumente()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<DokumentUlaza> listaDokumenataUlaza = database.dohvatiSveDokumenteUlaza();
                dgvDokumentiUlaza.Rows.Clear();
                for (int i = 0; i < listaDokumenataUlaza.Count; i++)
                {
                    dgvDokumentiUlaza.Rows.Add(listaDokumenataUlaza[i].Id, listaDokumenataUlaza[i].Naziv,
                        listaDokumenataUlaza[i].Datum, listaDokumenataUlaza[i].Zaposlenik.Id,
                        listaDokumenataUlaza[i].Zaposlenik.Prezime+" "+listaDokumenataUlaza[i].Zaposlenik.Ime,
                        listaDokumenataUlaza[i].PoslovniPartner.Id, listaDokumenataUlaza[i].PoslovniPartner.Naziv);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pokušajte osvježiti podatke klikom na gumb 'Dokumenti ulaza' jer spajanje s bazom podataka nije uspjelo.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
