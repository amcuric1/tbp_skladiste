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
    public partial class frmPoslovniPartneri : Form
    {
        Panel glavni;

        public frmPoslovniPartneri(Panel panel)
        {
            InitializeComponent();
            glavni = panel;
            dohvatiPoslovnePartnere();
            popuniComboGradovima();
        }

        private void frmPoslovniPartneri_Load(object sender, EventArgs e)
        {
            this.Parent = glavni;
        }

        private void bojanje(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Crimson;
        }
        private void micanjeBoje(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Silver;
        }

        private void prikaz(object sender, EventArgs e)
        {
            panel.Visible = true;
            if (sender == btnDodajPoslovnogPartnera)
            {
                btnSpremi.Text = "Dodaj";
                txtOIB.Enabled = true;
                txtOIB.Clear();
                txtNaziv.Clear();
                txtEmail.Clear();
                txtKontakt.Clear();
                dtpPocetakPartnerstva.Value = DateTime.Now;
                txtAdresa.Clear();
                comboGrad.SelectedIndex = -1;
            }
            else
            {
                if (dgvPoslovniPartneri.Rows.Count != 0)
                {
                    btnSpremi.Text = "Spremi";
                    txtOIB.Text = dgvPoslovniPartneri.CurrentRow.Cells[1].Value.ToString();
                    txtOIB.Enabled = false;
                    txtNaziv.Text = dgvPoslovniPartneri.CurrentRow.Cells[2].Value.ToString();
                    txtEmail.Text = dgvPoslovniPartneri.CurrentRow.Cells[3].Value.ToString();
                    txtKontakt.Text = dgvPoslovniPartneri.CurrentRow.Cells[4].Value.ToString();
                    dtpPocetakPartnerstva.Value = (DateTime)dgvPoslovniPartneri.CurrentRow.Cells[5].Value;
                    txtAdresa.Text = dgvPoslovniPartneri.CurrentRow.Cells[6].Value.ToString();
                    dohvatiOdabraniGrad();
                }
                else
                {
                    panel.Visible = false;
                    MessageBox.Show("Ne postoje zaposlenici koji se mogu izmijeniti!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void dohvatiPoslovnePartnere()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<PoslovniPartner> listaPartnera = database.dohvatiSvePoslovnePartnere();
                dgvPoslovniPartneri.Rows.Clear();
                for (int i = 0; i < listaPartnera.Count; i++)
                {
                    dgvPoslovniPartneri.Rows.Add(listaPartnera[i].Id, listaPartnera[i].OIB,
                        listaPartnera[i].Naziv, listaPartnera[i].Email, listaPartnera[i].Kontakt,
                        listaPartnera[i].DatumPocetkaPartnerstva, listaPartnera[i].Adresa,
                        listaPartnera[i].Grad.Id, listaPartnera[i].Grad.Naziv);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pokušajte osvježiti podatke klikom na gumb 'Poslovni partneri' jer spajanje s bazom podataka nije uspjelo.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        public void popuniComboGradovima()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<Grad> listaGradova = database.dohvatiGradove();
                comboGrad.Items.Clear();
                for (int i = 0; i < listaGradova.Count; i++)
                {
                    comboGrad.Items.Add(listaGradova[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguće osvježiti gradove. Molim Vas, pokušajte ponovno.",
                            "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                glavni.Controls.Clear();
            }
            
        }

        public void dohvatiOdabraniGrad()
        {
            int index = 0;
            for (int i = 0; i < comboGrad.Items.Count; i++)
            {
                if (((Grad)comboGrad.Items[i]).Id == int.Parse(dgvPoslovniPartneri.CurrentRow.Cells[7].Value.ToString()))
                {
                    index = i;
                }
            }
            comboGrad.SelectedIndex = index;

        }

        private void btnObrisiPoslovnogPartnera_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            try
            {
                PoslovniPartner partner = new PoslovniPartner();
                partner.Id = int.Parse(dgvPoslovniPartneri.CurrentRow.Cells[0].Value.ToString());
                RadSBazom databse = new RadSBazom();
                databse.obrisiPoslovnogPartnera(partner);
                dohvatiPoslovnePartnere();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ne postoji niti jedan poslovni partner!!",
                    "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Poslovni partner se ne može obrisati jer je povezan s dokumentima!",
                    "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Pokušajte obrisati podatak malo kasnije jer spajanje s bazom podataka trenutno nije uspjelo.",
                        "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtOIB.Text != "" && txtNaziv.Text != "" && txtEmail.Text != "" && txtKontakt.Text != "" && txtAdresa.Text != "" && comboGrad.SelectedIndex != -1)
            {
                if (btnSpremi.Text == "Dodaj")
                {
                    if (txtOIB.Text.Length == 11)
                    {
                        PoslovniPartner novi = new PoslovniPartner();
                        novi.OIB = txtOIB.Text;
                        novi.Naziv = txtNaziv.Text;
                        novi.Email = txtEmail.Text;
                        novi.Kontakt = txtKontakt.Text;
                        novi.DatumPocetkaPartnerstva = dtpPocetakPartnerstva.Value;
                        novi.Adresa = txtAdresa.Text;
                        novi.Grad = new Grad();
                        novi.Grad.Id = int.Parse(((Grad)comboGrad.SelectedItem).Id.ToString());
                        novi.Grad.Naziv = ((Grad)comboGrad.SelectedItem).Naziv.ToString();

                        try
                        {
                            RadSBazom database = new RadSBazom();
                            database.spremiPoslovnogPartnera(novi);
                            panel.Visible = false;
                            dohvatiPoslovnePartnere();
                        }
                        catch (Npgsql.PostgresException)
                        {
                            MessageBox.Show("Takav OIB već postoji!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Pokušajte osvježiti spremljene podatke klikom na gumb 'Poslovni partneri' jer spajanje s bazom podataka nije uspjelo.",
                            "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            glavni.Controls.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("OIB mora imati 11 znamenki!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    try
                    {
                        PoslovniPartner izmjena = new PoslovniPartner();
                        izmjena.Id = int.Parse(dgvPoslovniPartneri.CurrentRow.Cells[0].Value.ToString());
                        izmjena.OIB = txtOIB.Text;
                        izmjena.Naziv = txtNaziv.Text;
                        izmjena.Email = txtEmail.Text;
                        izmjena.Kontakt = txtKontakt.Text;
                        izmjena.DatumPocetkaPartnerstva = dtpPocetakPartnerstva.Value;
                        izmjena.Adresa = txtAdresa.Text;
                        izmjena.Grad = new Grad();
                        izmjena.Grad.Id = int.Parse(((Grad)comboGrad.SelectedItem).Id.ToString());
                        izmjena.Grad.Naziv = ((Grad)comboGrad.SelectedItem).Naziv.ToString();
                        RadSBazom databse = new RadSBazom();
                        databse.azurirajPoslovnogPartnera(izmjena);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Pokušajte osvježiti izmijenjene podatke klikom na gumb 'Poslovni partneri' jer spajanje s bazom podataka nije uspjelo.",
                             "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        glavni.Controls.Clear();
                    }
                    panel.Visible = false;
                    dohvatiPoslovnePartnere();
                }
            }
            else
            {
                MessageBox.Show("Podaci nisu pravilno uneseni!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        private void dgvPoslovniPartneri_SelectionChanged(object sender, EventArgs e)
        {
            txtOIB.Text = dgvPoslovniPartneri.CurrentRow.Cells[1].Value.ToString();
            txtNaziv.Text = dgvPoslovniPartneri.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvPoslovniPartneri.CurrentRow.Cells[3].Value.ToString();
            txtKontakt.Text = dgvPoslovniPartneri.CurrentRow.Cells[4].Value.ToString();
            dtpPocetakPartnerstva.Value = (DateTime)dgvPoslovniPartneri.CurrentRow.Cells[5].Value;
            txtAdresa.Text = dgvPoslovniPartneri.CurrentRow.Cells[6].Value.ToString();
            dohvatiOdabraniGrad();
        }
    }
}
