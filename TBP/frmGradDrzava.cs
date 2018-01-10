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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace TBP
{
    public partial class frmGradDrzava : Form
    {
        Panel glavni;

        public frmGradDrzava(Panel panel)
        {
            InitializeComponent();
            glavni = panel;
            dohvatiSveDrzave();
            popuniComboDrzavama();
            dohvatiSveGradove();
        }

        private void frmGradDrzava_Load(object sender, EventArgs e)
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





        private void prikazDrzave(object sender, EventArgs e)
        {
            lblNazivDrzave.Visible = true;
            txtNazivDrzave.Visible = true;
            btnSpremiDrzavu.Visible = true;
            if (sender == btnDodajDrzavu)
            {
                txtNazivDrzave.Clear();
                btnSpremiDrzavu.Text = "Dodaj";
            }
            else
            {
                txtNazivDrzave.Text = dgvDrzave.CurrentRow.Cells[1].Value.ToString();
                btnSpremiDrzavu.Text = "Spremi";
            }
        }

        private void prikazGrada(object sender, EventArgs e)
        {
            lblNazivGrada.Visible = true;
            txtNazivGrada.Visible = true;
            lblDrzava.Visible = true;
            comboDrzava.Visible = true;
            btnSpremiGrad.Visible = true;
            pbPomoc.Visible = true;
            if (sender == btnDodajGrad)
            {
                txtNazivGrada.Clear();
                btnSpremiGrad.Text = "Dodaj";
                comboDrzava.SelectedIndex = -1;
            }
            else
            {
                txtNazivGrada.Text = dgvGradovi.CurrentRow.Cells[1].Value.ToString();
                azurirajComboSDrzavama();
                btnSpremiGrad.Text = "Spremi";
            }
        }




        //Države

        private void btnSpremiDrzavu_Click(object sender, EventArgs e)
        {
            if (txtNazivDrzave.Text != "")
            {
                if (btnSpremiDrzavu.Text == "Dodaj")
                {
                    try
                    {
                        RadSBazom database = new RadSBazom();
                        Drzava nova = new Drzava();
                        nova.Naziv = txtNazivDrzave.Text;
                        database.spremiDrzavu(nova);
                        txtNazivDrzave.Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Pokušajte osvježiti spremljene podatke klikom na gumb 'Lokacija' jer spajanje s bazom podataka trenutno nije uspjelo.",
                            "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);                    

                        glavni.Controls.Clear();
                    }
                    lblNazivDrzave.Visible = false;
                    txtNazivDrzave.Visible = false;
                    btnSpremiDrzavu.Visible = false;
                }
                else
                {
                    try
                    {
                        RadSBazom database = new RadSBazom();
                        Drzava izmjena = new Drzava();
                        izmjena.Id = int.Parse(dgvDrzave.CurrentRow.Cells[0].Value.ToString());
                        izmjena.Naziv = txtNazivDrzave.Text;
                        database.izmijeniDrzavu(izmjena);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Pokušajte osvježiti izmijenjene podatke klikom na gumb 'Lokacija' jer spajanje s bazom podataka trenutno nije uspjelo.",
                            "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        String poruka = ex.StackTrace;
                        MessageBox.Show(poruka);
                        glavni.Controls.Clear();
                    }
                    lblNazivDrzave.Visible = false;
                    txtNazivDrzave.Visible = false;
                    btnSpremiDrzavu.Visible = false;
                }
                dohvatiSveDrzave();
                popuniComboDrzavama();
                dohvatiSveGradove();
            }
            else
            {
                MessageBox.Show("Podaci nisu pravilno uneseni!",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void dohvatiSveDrzave()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<Drzava> listaDrzava = database.dohvatiSveDrzave();
                dgvDrzave.Rows.Clear();
                for (int i = 0; i < listaDrzava.Count; i++)
                {
                    dgvDrzave.Rows.Add(listaDrzava[i].Id, listaDrzava[i].Naziv);
                }
                popuniComboDrzavama();
            }
            catch (Exception)
            {
                MessageBox.Show("Pokušajte osvježiti podatke klikom na gumb 'Lokacija' jer spajanje s bazom podataka trenutno nije uspjelo.",
                             "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                glavni.Controls.Clear();
            }
            
        }

        private void dgvDrzave_SelectionChanged(object sender, EventArgs e)
        {
            if (btnSpremiDrzavu.Text == "Spremi")
            {
                txtNazivDrzave.Text=dgvDrzave.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnObrisiDrzavu_Click(object sender, EventArgs e)
        {
            try
            {
                RadSBazom database = new RadSBazom();
                Drzava stara = new Drzava();
                stara.Id = int.Parse(dgvDrzave.CurrentRow.Cells[0].Value.ToString());
                database.brisanjeDrzave(stara);
                dohvatiSveDrzave();
                popuniComboDrzavama();
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Odabranu državu nije moguće obrisati jer je povezana s određenim gradom.",
                  "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ne postoji niti jedna država!!",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Pokušajte obrisati podatak malo kasnije jer spajanje s bazom podataka trenutno nije uspjelo.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }







        //Grad
        public void popuniComboDrzavama()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<Drzava> listaDrzava = database.dohvatiSveDrzave();
                comboDrzava.Items.Clear();
                for (int i = 0; i < listaDrzava.Count; i++)
                {
                    comboDrzava.Items.Add(listaDrzava[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pokušajte osvježiti podatke klikom na gumb 'Lokacija' jer spajanje s bazom podataka trenutno nije uspjelo.",
                             "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                glavni.Controls.Clear();
            }
        }

        public void dohvatiSveGradove()
        {
            try
            {
                RadSBazom database = new RadSBazom();
                List<Grad> listaGradova = database.dohvatiGradove();
                dgvGradovi.Rows.Clear();
                for (int i = 0; i < listaGradova.Count; i++)
                {
                    dgvGradovi.Rows.Add(listaGradova[i].Id, listaGradova[i].Naziv, listaGradova[i].Drzava.Id, listaGradova[i].Drzava.Naziv);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pokušajte osvježiti podatke klikom na gumb 'Lokacija' jer spajanje s bazom podataka trenutno nije uspjelo.",
                            "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                glavni.Controls.Clear();
            }
            
        }

        public void azurirajComboSDrzavama()
        {
            int indexDrzave = 0;
            for (int i = 0; i < comboDrzava.Items.Count; i++)
            {
                if (((Drzava)comboDrzava.Items[i]).Id == int.Parse(dgvGradovi.CurrentRow.Cells[2].Value.ToString()))
                {
                    indexDrzave = i;
                }
            }
            comboDrzava.SelectedIndex = indexDrzave;
        }

        private void btnSpremiGrad_Click(object sender, EventArgs e)
        {
            if (btnSpremiGrad.Text == "Dodaj")
            {
                if (txtNazivGrada.Text != "")
                {
                    if (comboDrzava.SelectedIndex != -1)
                    {
                        try
                        {
                            Grad novi = new Grad();
                            novi.Naziv = txtNazivGrada.Text.ToString();
                            novi.Drzava = new Drzava();
                            novi.Drzava.Id = int.Parse(((Drzava)comboDrzava.SelectedItem).Id.ToString());
                            novi.Drzava.Naziv = ((Drzava)comboDrzava.SelectedItem).Naziv.ToString();
                            RadSBazom database = new RadSBazom();
                            database.spremiGrad(novi);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Pokušajte osvježiti spremljene podatke klikom na gumb 'Lokacija' jer spajanje s bazom podataka nije uspjelo.",
                             "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            glavni.Controls.Clear();
                        }
                        lblNazivGrada.Visible = false;
                        txtNazivGrada.Visible = false;
                        lblDrzava.Visible = false;
                        comboDrzava.Visible = false;
                        btnSpremiGrad.Visible = false;
                        pbPomoc.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Dodavanje se ne može izvršiti jer država nije pravilno unesena!",
                        "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Dodavanje se ne može izvršiti jer naziv nije pravilno unesen!",
                    "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtNazivGrada.Text != "")
                {
                    try
                    {
                        Grad izmjena = new Grad();
                        izmjena.Id = int.Parse(dgvGradovi.CurrentRow.Cells[0].Value.ToString());
                        izmjena.Naziv = txtNazivGrada.Text;
                        izmjena.Drzava = new Drzava();
                        izmjena.Drzava.Id = int.Parse(((Drzava)comboDrzava.SelectedItem).Id.ToString());
                        izmjena.Drzava.Naziv = ((Drzava)comboDrzava.SelectedItem).Naziv.ToString();
                        RadSBazom database = new RadSBazom();
                        database.azurirajGrad(izmjena);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Pokušajte osvježiti izmijenjene podatke klikom na gumb 'Lokacija' jer spajanje s bazom podataka nije uspjelo.",
                             "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        glavni.Controls.Clear();
                    }
                    lblNazivGrada.Visible = false;
                    txtNazivGrada.Visible = false;
                    lblDrzava.Visible = false;
                    comboDrzava.Visible = false;
                    btnSpremiGrad.Visible = false;
                    pbPomoc.Visible = false;
                }
                else
                {
                    MessageBox.Show("Dodavanje se ne može izvršiti jer naziv nije pravilno unesen!",
                    "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dohvatiSveGradove();
        }

        private void dgvGradovi_SelectionChanged(object sender, EventArgs e)
        {
            if (btnSpremiGrad.Text == "Spremi")
            {
                txtNazivGrada.Text = dgvGradovi.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnObrisiGrad_Click(object sender, EventArgs e)
        {
            try
            {
                Grad zaBrisati = new Grad();
                zaBrisati.Id = int.Parse(dgvGradovi.CurrentRow.Cells[0].Value.ToString());
                RadSBazom database = new RadSBazom();
                database.obrisiGrad(zaBrisati);
                dohvatiSveGradove();
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Odabrani grad nije moguće obrisati jer je povezan s određenim zaposlenicima i/ili poslovnim partnerima.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ne postoji niti jedan grad!!",
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