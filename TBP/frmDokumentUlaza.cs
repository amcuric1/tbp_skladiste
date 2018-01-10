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
    public partial class frmDokumentUlaza : Form
    {
        public frmDokumentUlaza()
        {
            InitializeComponent();
            popuniListBoxPotrebnimArtiklima();
            popuniComboZaposlenicima();
            popuniComboPoslovnimPartnerima();
            popuniComboArtiklima();
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


        private bool validacija()
        {
            bool tocanUnos = true;
            if (txtNaziv.Text == "") tocanUnos = false;
            if (comboZaposlenici.SelectedIndex == -1) tocanUnos=false;
            if (comboPoslovniPartneri.SelectedIndex == -1) tocanUnos = false;
            if (dgvDodaniArtikli.Rows.Count < 1) tocanUnos = false;
            return tocanUnos;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                DokumentUlaza dokument = new DokumentUlaza();
                dokument.Naziv = txtNaziv.Text;
                dokument.Datum = dtpDatum.Value;
                dokument.Zaposlenik= (Zaposlenik)comboZaposlenici.SelectedItem;
                dokument.PoslovniPartner = (PoslovniPartner)comboPoslovniPartneri.SelectedItem;
                
                for (int i = 0; i < dgvDodaniArtikli.RowCount; i++)
                {
                    StavkeDokumentaUlaza stavka = new StavkeDokumentaUlaza();
                    stavka.Artikl = new Artikl();
                    
                    stavka.Artikl.Id = int.Parse(dgvDodaniArtikli.Rows[i].Cells[0].Value.ToString());
                    stavka.Kolicina= int.Parse(dgvDodaniArtikli.Rows[i].Cells[2].Value.ToString());
                    dokument.Stavke.Add(stavka);
                }
                try
                {
                    RadSBazom database = new RadSBazom();
                    database.spremiUlazniDokument(dokument);
                }
                catch (Exception)
                {
                    MessageBox.Show("Došlo je do greške u radu s bazom!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Podaci nisu pravilno uneseni!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void popuniListBoxPotrebnimArtiklima()
        {
            RadSBazom database = new RadSBazom();
            List<Artikl> listaArtikala = database.dohvatiPotrebneArtikle();
            lboxPotrebniArtikli.ResetText();
            if (listaArtikala.Count > 0)
            {
                for (int i = 0; i < listaArtikala.Count; i++)
                {
                    int potrebno = 0;
                    potrebno = listaArtikala[i].MinimalnaKolicinaNaSkladistu - listaArtikala[i].KolicinaNaSkladistu;
                    lboxPotrebniArtikli.Items.Add(listaArtikala[i].Naziv + "  ->  Nedostaje " + potrebno);
                }
            }
            else
            {
                lboxPotrebniArtikli.Items.Add("Ne postoje artikli čija je količina");
                lboxPotrebniArtikli.Items.Add("na skladištu manja od minimalne");
                lboxPotrebniArtikli.Items.Add("dopuštene količine!");
            }
        }

        private void popuniComboZaposlenicima()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<Zaposlenik> listaZaposlenika = database.dohvatiSveZaposlenike();
                comboZaposlenici.Items.Clear();
                for (int i = 0; i < listaZaposlenika.Count; i++)
                {
                    comboZaposlenici.Items.Add(listaZaposlenika[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguće osvježiti zaposlenike koji se mogu dodati na dokument. Molim Vas, pokušajte ponovno.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void popuniComboPoslovnimPartnerima()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<PoslovniPartner> listaPartnera = database.dohvatiSvePoslovnePartnere();
                comboPoslovniPartneri.Items.Clear();
                for (int i = 0; i < listaPartnera.Count; i++)
                {
                    comboPoslovniPartneri.Items.Add(listaPartnera[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguće osvježiti poslovne partnere koji se mogu dodati na dokument. Molim Vas, pokušajte ponovno.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void popuniComboArtiklima()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<Artikl> listaArtikala = database.dohvatiSveArtikle();
                comboArtikli.Items.Clear();
                for (int i = 0; i < listaArtikala.Count; i++)
                {
                    comboArtikli.Items.Add(listaArtikala[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguće osvježiti artikle koji se mogu dodati na dokument. Molim Vas, pokušajte ponovno.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            if (comboArtikli.SelectedIndex !=-1 && provjeraKolicine(txtKolicina.Text))
            {
                Artikl odabrani = (Artikl)comboArtikli.SelectedItem;
                dgvDodaniArtikli.Rows.Add(odabrani.Id, odabrani.Naziv, txtKolicina.Text);
                makniDodaniArtiklIzComba();
                txtKolicina.Clear();

                if (comboArtikli.Items.Count != 0)
                {
                    comboArtikli.SelectedIndex = -1;
                    comboArtikli.SelectedText = "";
                }
                else
                {
                    comboArtikli.Text = "";
                    comboArtikli.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Podaci su pogrešno upisani!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void makniDodaniArtiklIzComba()
        {
            comboArtikli.Items.Remove((Artikl)comboArtikli.SelectedItem);
        }



        private bool provjeraKolicine(string kolicina)
        {
            int broj = 0;
            if (int.TryParse(kolicina, out broj))
            {
                if (broj > 0)
                {
                    return true;
                }
            }
            return false;
        }



        private void btnObrisiArtikl_Click(object sender, EventArgs e)
        {
            if (dgvDodaniArtikli.SelectedRows.Count!=0)
            {
                comboArtikli.Enabled = true;
                int idOdabranog = int.Parse(dgvDodaniArtikli.CurrentRow.Cells[0].Value.ToString());
                string nazivOdabranog = dgvDodaniArtikli.CurrentRow.Cells[1].Value.ToString();
                Artikl noviZaCombo = new Artikl();
                noviZaCombo.Id = idOdabranog;
                noviZaCombo.Naziv = nazivOdabranog;
                comboArtikli.Items.Add(noviZaCombo);
                comboArtikli.Sorted = true;
                dgvDodaniArtikli.Rows.RemoveAt(dgvDodaniArtikli.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Ne postoji niti jedan odabrani artikl za brisanje!",
                    "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
