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
    public partial class frmZaposlenici : Form
    {
        Panel glavni;

        public frmZaposlenici(Panel panel)
        {
            InitializeComponent();
            glavni = panel;
            dohvatiSveZaposlenike();
            popuniComboGradovima();
        }

        private void frmZaposlenici_Load(object sender, EventArgs e)
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

        private void prikazDodavanjaIzmjene (object sender, EventArgs e)
        {
            panel.Visible = true;
            if (sender == btnDodajZaposlenika)
            {
                btnSpremi.Text = "Dodaj";
                txtOIB.Enabled = true;
                txtOIB.Clear();
                txtIme.Clear();
                txtPrezime.Clear();
                txtEmail.Clear();
                txtKontakt.Clear();
                dtpDatumZaposlenja.Value=DateTime.Now;
                txtAdresa.Clear();
                comboGrad.SelectedIndex = -1;
            }
            else
            {
                if (dgvZaposlenici.Rows.Count != 0)
                {
                    btnSpremi.Text = "Spremi";
                    txtOIB.Text = dgvZaposlenici.CurrentRow.Cells[1].Value.ToString();
                    txtOIB.Enabled = false;
                    txtIme.Text = dgvZaposlenici.CurrentRow.Cells[2].Value.ToString();
                    txtPrezime.Text = dgvZaposlenici.CurrentRow.Cells[3].Value.ToString();
                    txtEmail.Text = dgvZaposlenici.CurrentRow.Cells[4].Value.ToString();
                    txtKontakt.Text = dgvZaposlenici.CurrentRow.Cells[5].Value.ToString();
                    dtpDatumZaposlenja.Value = (DateTime)dgvZaposlenici.CurrentRow.Cells[6].Value;
                    txtAdresa.Text = dgvZaposlenici.CurrentRow.Cells[7].Value.ToString();
                    dohvatiOdabraniGrad();
                }
                else
                {
                    panel.Visible = false;
                    MessageBox.Show("Ne postoje zaposlenici koji se mogu izmijeniti!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void dohvatiOdabraniGrad()
        {
            int indexDrzave = 0;
            for (int i = 0; i < comboGrad.Items.Count; i++)
            {
                if (((Grad)comboGrad.Items[i]).Id == int.Parse(dgvZaposlenici.CurrentRow.Cells[8].Value.ToString()))
                {
                    indexDrzave = i;
                }
            }
            comboGrad.SelectedIndex = indexDrzave;
        }

        public void dohvatiSveZaposlenike()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<Zaposlenik> listaZaposlenika = database.dohvatiSveZaposlenike();
                dgvZaposlenici.Rows.Clear();
                for (int i = 0; i < listaZaposlenika.Count; i++)
                {
                    dgvZaposlenici.Rows.Add(listaZaposlenika[i].Id, listaZaposlenika[i].OIB, listaZaposlenika[i].Ime,
                        listaZaposlenika[i].Prezime, listaZaposlenika[i].Email, listaZaposlenika[i].Kontakt,
                        listaZaposlenika[i].DatumZaposlenja, listaZaposlenika[i].Adresa,
                        listaZaposlenika[i].Grad.Id, listaZaposlenika[i].Grad.Naziv);
                }
            } 
                catch (Exception)
            {
                MessageBox.Show("Pokušajte osvježiti podatke klikom na gumb 'Zaposlenici' jer spajanje s bazom podataka nije uspjelo.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }            
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                if (btnSpremi.Text == "Dodaj")
                {
                    if (txtOIB.Text.Length == 11)
                    {
                        Zaposlenik novi = new Zaposlenik();
                        novi.OIB = txtOIB.Text;
                        novi.Ime = txtIme.Text;
                        novi.Prezime = txtPrezime.Text;
                        novi.Email = txtEmail.Text;
                        novi.Kontakt = txtKontakt.Text;
                        novi.DatumZaposlenja = dtpDatumZaposlenja.Value;
                        novi.Adresa = txtAdresa.Text;
                        novi.Grad = new Grad();
                        novi.Grad.Id = int.Parse(((Grad)comboGrad.SelectedItem).Id.ToString());
                        novi.Grad.Naziv = ((Grad)comboGrad.SelectedItem).Naziv.ToString();                       

                        try
                        {
                            RadSBazom database = new RadSBazom();
                            database.spremiZaposlenika(novi);
                            panel.Visible = false;
                            dohvatiSveZaposlenike();
                        }
                        catch(Npgsql.PostgresException)
                        {
                            MessageBox.Show("Takav OIB već postoji!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Pokušajte osvježiti spremljene podatke klikom na gumb 'Zaposlenici' jer spajanje s bazom podataka nije uspjelo.",
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
                        Zaposlenik izmjena = new Zaposlenik();
                        izmjena.Id = int.Parse(dgvZaposlenici.CurrentRow.Cells[0].Value.ToString());
                        izmjena.OIB = txtOIB.Text;
                        izmjena.Ime = txtIme.Text;
                        izmjena.Prezime = txtPrezime.Text;
                        izmjena.Email = txtEmail.Text;
                        izmjena.Kontakt = txtKontakt.Text;
                        izmjena.DatumZaposlenja = dtpDatumZaposlenja.Value;
                        izmjena.Adresa = txtAdresa.Text;
                        izmjena.Grad = new Grad();
                        izmjena.Grad.Id = int.Parse(((Grad)comboGrad.SelectedItem).Id.ToString());
                        izmjena.Grad.Naziv = ((Grad)comboGrad.SelectedItem).Naziv.ToString();
                        RadSBazom databse = new RadSBazom();
                        databse.azurirajZaposlenika(izmjena);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Pokušajte osvježiti izmijenjene podatke klikom na gumb 'Zaposlenici' jer spajanje s bazom podataka nije uspjelo.",
                               "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        glavni.Controls.Clear();
                    }
                    panel.Visible = false;
                    dohvatiSveZaposlenike();
                }
            }
            else
            {
                MessageBox.Show("Podaci nisu pravilno uneseni!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validacija()
        {
            bool tocanUnos = true;

            if (txtOIB.Text == "") tocanUnos = false;
            if (txtIme.Text == "") tocanUnos = false;
            if (txtPrezime.Text == "") tocanUnos = false;
            if (txtEmail.Text == "") tocanUnos = false;
            if (txtKontakt.Text == "")  tocanUnos = false;
            if (txtAdresa.Text == "") tocanUnos = false;
            if (comboGrad.SelectedIndex == -1) tocanUnos = false;
      
            return tocanUnos;
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

        private void dgvZaposlenici_SelectionChanged(object sender, EventArgs e)
        {
            txtOIB.Text = dgvZaposlenici.CurrentRow.Cells[1].Value.ToString();
            txtIme.Text = dgvZaposlenici.CurrentRow.Cells[2].Value.ToString();
            txtPrezime.Text = dgvZaposlenici.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvZaposlenici.CurrentRow.Cells[4].Value.ToString();
            txtKontakt.Text = dgvZaposlenici.CurrentRow.Cells[5].Value.ToString();
            dtpDatumZaposlenja.Value = (DateTime)dgvZaposlenici.CurrentRow.Cells[6].Value;
            txtAdresa.Text = dgvZaposlenici.CurrentRow.Cells[7].Value.ToString();
            dohvatiOdabraniGrad();
        }

        private void btnObrisiZaposlenika_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            try
            {
                Zaposlenik zaBrisanje = new Zaposlenik();
                zaBrisanje.Id = int.Parse(dgvZaposlenici.CurrentRow.Cells[0].Value.ToString());
                RadSBazom databse = new RadSBazom();
                databse.obrisiZaposlenika(zaBrisanje);
                dohvatiSveZaposlenike();
            }
            catch (NullReferenceException)
            { 
                    MessageBox.Show("Ne postoji niti jedan zaposlenik!!",
                    "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Npgsql.PostgresException)
            { 
                    MessageBox.Show("Zaposlenik se ne može obrisati jer je povezan s dokumentima!",
                        "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Pokušajte obrisati podatak malo kasnije jer spajanje s bazom podataka trenutno nije uspjelo.",
                        "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
