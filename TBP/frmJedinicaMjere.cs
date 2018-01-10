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
    public partial class frmJedinicaMjere : Form
    {
        public frmJedinicaMjere()
        {
            InitializeComponent();
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
            lblNaziv.Visible = true;
            txtNaziv.Visible = true;
            btnSpremi.Visible = true;
            prikazGumbaSpremi(sender, e);
        }

        private void frmJedinicaMjere_Load(object sender, EventArgs e)
        {
            osvjeziPodatke();
        }

        private void prikazGumbaSpremi(object sender, EventArgs e)
        {
            if (btnDodajMjeru == sender)
            {
                btnSpremi.Text = "Dodaj";
                txtNaziv.Clear();
            }
            else
            {
                btnSpremi.Text = "Spremi";
                txtNaziv.Text = dgvPopisJedinicaMjere.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "")
            {
                if (btnSpremi.Text == "Dodaj")
                {
                    try
                    {
                        JedinicaMjereArtikla novaJedinica = new JedinicaMjereArtikla();
                        novaJedinica.Naziv = txtNaziv.Text;
                        RadSBazom database = new RadSBazom();
                        database.spremiJedinicuMjere(novaJedinica);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Pokušajte osvježiti spremljene podatke klikom na gumb 'Jedinica mjere artikla' jer spajanje s bazom podataka nije uspjelo.",
                             "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    txtNaziv.Clear();

                    lblNaziv.Visible = false;
                    txtNaziv.Visible = false;
                    btnSpremi.Visible = false;
                }
                else
                {
                    try
                    {
                        JedinicaMjereArtikla izmjena = new JedinicaMjereArtikla();
                        izmjena.Id = int.Parse(dgvPopisJedinicaMjere.CurrentRow.Cells[0].Value.ToString());
                        izmjena.Naziv = txtNaziv.Text;
                        RadSBazom database = new RadSBazom();
                        database.izmijeniJedinicuMjere(izmjena);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Pokušajte osvježiti izmijenjene podatke klikom na gumb 'Jedinica mjere artikla' jer spajanje s bazom podataka nije uspjelo",
                            "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    
                    txtNaziv.Clear();

                    lblNaziv.Visible = false;
                    txtNaziv.Visible = false;
                    btnSpremi.Visible = false;
                }
                osvjeziPodatke();
            }
            else
            {
                MessageBox.Show("Dodavanje se ne može izvršiti jer naziv nije pravilno unesen!",
                        "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        void osvjeziPodatke()
        {
            try
            {
                RadSBazom database = new RadSBazom();

                List<JedinicaMjereArtikla> lista = database.dohvatiSveJediniceMjeraArtikla();

                dgvPopisJedinicaMjere.Rows.Clear();

                for (int i = 0; i < lista.Count; i++)
                {
                    dgvPopisJedinicaMjere.Rows.Add(lista[i].Id, lista[i].Naziv);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Pokušajte osvježiti podatke klikom na gumb 'Jedinica mjere artikla' jer spajanje s bazom podataka nije uspjelo.",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void dgvPopisJedinicaMjere_SelectionChanged(object sender, EventArgs e)
        {
            if (btnSpremi.Text == "Spremi")
            {
                txtNaziv.Text = dgvPopisJedinicaMjere.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
           try
            {
                JedinicaMjereArtikla mjeraZaBrisanje = new JedinicaMjereArtikla();
                mjeraZaBrisanje.Id = int.Parse(dgvPopisJedinicaMjere.CurrentRow.Cells[0].Value.ToString());
                RadSBazom database = new RadSBazom();
                database.brisanjeJediniceMjere(mjeraZaBrisanje);
                osvjeziPodatke();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ne postoji niti jedna jedinica mjere artikla!!",
                "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Odabranu mjeru nije moguće obrisati jer je povezana s određenim artiklom.",
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
