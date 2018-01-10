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
    public partial class frmArtikli : Form
    {
        Panel glavni;

        public frmArtikli(Panel panel)
        {
            InitializeComponent();
            glavni = panel;
            dohvatiSveArtikle();
            popuniComboMjerama();
        }

        private void frmArtikli_Load(object sender, EventArgs e)
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
            if (sender == btnDodajArtikl)
            {
                panel.Visible = true;
                btnSpremi.Text = "Dodaj";
                txtNaziv.Clear();
                txtMinimalnaKoličina.Clear();
                txtKolicinaNaSkladistu.Clear();
                txtJedinicnaCijena.Clear();
                comboJedinicaMjere.SelectedIndex = -1;
            }
            else
            {
                if (dgvArtikli.Rows.Count != 0)
                {
                    panel.Visible = true;
                    btnSpremi.Text = "Spremi";
                    txtNaziv.Text = dgvArtikli.CurrentRow.Cells[1].Value.ToString();
                    txtJedinicnaCijena.Text = dgvArtikli.CurrentRow.Cells[2].Value.ToString();
                    txtKolicinaNaSkladistu.Text = dgvArtikli.CurrentRow.Cells[3].Value.ToString();
                    txtMinimalnaKoličina.Text = dgvArtikli.CurrentRow.Cells[4].Value.ToString();
                    dohvatiOdabraniArtikl();
                }
                else
                {
                    panel.Visible = false;
                    MessageBox.Show("Ne postoje artikli koji se mogu izmijeniti!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        public void popuniComboMjerama()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<JedinicaMjereArtikla> listaMjera = database.dohvatiSveJediniceMjeraArtikla();
                comboJedinicaMjere.Items.Clear();
                for (int i = 0; i < listaMjera.Count; i++)
                {
                    comboJedinicaMjere.Items.Add(listaMjera[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguće osvježiti jedinice mjera artikala. Molim Vas, pokušajte ponovno.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                glavni.Controls.Clear();
            }
        }



        public void dohvatiOdabraniArtikl()
        {
            int indexArtikla = 0;
            for (int i = 0; i < comboJedinicaMjere.Items.Count; i++)
            {
                if (((JedinicaMjereArtikla)comboJedinicaMjere.Items[i]).Id == int.Parse(dgvArtikli.CurrentRow.Cells[5].Value.ToString()))
                {
                    indexArtikla = i;
                }
            }
            comboJedinicaMjere.SelectedIndex = indexArtikla;
        }

        //Jedinica mjere
        private void btnJedinicaMjere_Click(object sender, EventArgs e)
        {
            frmJedinicaMjere frmJedinicaMjere = new frmJedinicaMjere();
            frmJedinicaMjere.ShowDialog();
        }






        public void dohvatiSveArtikle()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<Artikl> listaArtikala = database.dohvatiSveArtikle();
                dgvArtikli.Rows.Clear();
                for (int i = 0; i < listaArtikala.Count; i++)
                {
                    dgvArtikli.Rows.Add(listaArtikala[i].Id, listaArtikala[i].Naziv, listaArtikala[i].JedinicnaCijena,
                        listaArtikala[i].KolicinaNaSkladistu, listaArtikala[i].MinimalnaKolicinaNaSkladistu,
                        listaArtikala[i].JedinicaMjere.Id, listaArtikala[i].JedinicaMjere.Naziv);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pokušajte osvježiti podatke klikom na gumb 'Artikli' jer spajanje s bazom podataka nije uspjelo.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(validacija())
            {
                if (btnSpremi.Text == "Dodaj")
                {
                    Artikl novi = new Artikl();
                    novi.Naziv = txtNaziv.Text;
                    novi.JedinicnaCijena = float.Parse(txtJedinicnaCijena.Text.ToString());
                    novi.KolicinaNaSkladistu = int.Parse(txtKolicinaNaSkladistu.Text.ToLower());
                    novi.MinimalnaKolicinaNaSkladistu = int.Parse(txtMinimalnaKoličina.Text.ToLower());
                    novi.JedinicaMjere = new JedinicaMjereArtikla();
                    novi.JedinicaMjere.Id = int.Parse(((JedinicaMjereArtikla)comboJedinicaMjere.SelectedItem).Id.ToString());
                    novi.JedinicaMjere.Naziv = ((JedinicaMjereArtikla)comboJedinicaMjere.SelectedItem).Naziv.ToString();
                  /*  try
                    {*/
                        RadSBazom database = new RadSBazom();
                        database.spremiArtikl(novi);
                        panel.Visible = false;
                        dohvatiSveArtikle();
                 /*   }
                    catch (Exception)
                    {
                        MessageBox.Show("Pokušajte osvježiti spremljene podatke klikom na gumb 'Artikli' jer spajanje s bazom podataka nije uspjelo.",
                        "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        glavni.Controls.Clear();
                    }*/
                }
                else
                {
                    try
                    {
                        Artikl izmjena = new Artikl();
                        izmjena.Id = int.Parse(dgvArtikli.CurrentRow.Cells[0].Value.ToString());
                        izmjena.Naziv = txtNaziv.Text;
                        izmjena.JedinicnaCijena = float.Parse(txtJedinicnaCijena.Text);
                        izmjena.KolicinaNaSkladistu = int.Parse(txtKolicinaNaSkladistu.Text.ToString());
                        izmjena.MinimalnaKolicinaNaSkladistu = int.Parse(txtMinimalnaKoličina.Text.ToString());
                        izmjena.JedinicaMjere = new JedinicaMjereArtikla();
                        izmjena.JedinicaMjere.Id = int.Parse(((JedinicaMjereArtikla)comboJedinicaMjere.SelectedItem).Id.ToString());
                        izmjena.JedinicaMjere.Naziv = ((JedinicaMjereArtikla)comboJedinicaMjere.SelectedItem).Naziv.ToString();
                        RadSBazom databse = new RadSBazom();
                        databse.azurirajArtikl(izmjena);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Pokušajte osvježiti izmijenjene podatke klikom na gumb 'Artikli' jer spajanje s bazom podataka nije uspjelo.",
                               "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        glavni.Controls.Clear();
                    }
                    panel.Visible = false;
                    dohvatiSveArtikle();
                }
            }
            else
            {
                MessageBox.Show("Podaci nisu pravilno uneseni!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validacija()
        {
            bool tocnoUneseni = true;
            if (txtJedinicnaCijena.Text == "") tocnoUneseni = false;
            if (txtNaziv.Text == "") tocnoUneseni = false;
            if (txtKolicinaNaSkladistu.Text == "") tocnoUneseni = false;
            if (txtMinimalnaKoličina.Text == "") tocnoUneseni = false;
            if (comboJedinicaMjere.SelectedIndex == -1) tocnoUneseni = false;
            try
            {
                int.Parse(txtKolicinaNaSkladistu.Text.ToString());
                int.Parse(txtMinimalnaKoličina.Text.ToString());
                float.Parse(txtJedinicnaCijena.Text.ToString());
            }
            catch (SyntaxErrorException)
            {
                tocnoUneseni = false;
            }
            catch (FormatException)
            {
                tocnoUneseni = false;
            }
            return tocnoUneseni;
        }
    

        private void btnObrisiArtikl_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            try
            {
                Artikl zaBrisanje = new Artikl();
                zaBrisanje.Id = int.Parse(dgvArtikli.CurrentRow.Cells[0].Value.ToString());
                RadSBazom databse = new RadSBazom();
                databse.obrisiArtikl(zaBrisanje);
                dohvatiSveArtikle();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ne postoji niti jedan artikl!!",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Artikl se ne može obrisati jer je povezan s dokumentima!",
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
