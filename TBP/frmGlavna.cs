using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP
{
    public partial class frmGlavna : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        ucOAplikaciji ucOAplikaciji = new ucOAplikaciji();
        public frmGlavna()
        {
            InitializeComponent();
            pnlOznaka.Height = btnOaplikaciji.Height;
            pnlOznaka.Top = btnOaplikaciji.Top;
            btnOaplikaciji.ForeColor = Color.Crimson;
            pnlSadrzaj.Controls.Add(ucOAplikaciji);
        }

        private void btnOaplikaciji_Click(object sender, EventArgs e)
        {
            pnlOznaka.Height = btnOaplikaciji.Height;
            pnlOznaka.Top = btnOaplikaciji.Top;
            pnlSadrzaj.Controls.Clear();

            bojanjeTekstaGumba(sender, e);
            pnlSadrzaj.Controls.Add(ucOAplikaciji);
            ucOAplikaciji.Size = pnlSadrzaj.Size;
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            pnlOznaka.Height = btnArtikli.Height;
            pnlOznaka.Top = btnArtikli.Top;
            bojanjeTekstaGumba(sender, e);

            pnlSadrzaj.Controls.Clear();
            frmArtikli frmArtikli = new frmArtikli(pnlSadrzaj);
            frmArtikli.TopLevel = false;
            pnlSadrzaj.Controls.Add(frmArtikli);
            frmArtikli.Show();
        }

        private void btnPoslovniPartneri_Click(object sender, EventArgs e)
        {
            pnlOznaka.Height = btnPoslovniPartneri.Height;
            pnlOznaka.Top = btnPoslovniPartneri.Top;
            bojanjeTekstaGumba(sender, e);

            pnlSadrzaj.Controls.Clear();
            frmPoslovniPartneri frmPoslovniPartneri = new frmPoslovniPartneri(pnlSadrzaj);
            frmPoslovniPartneri.TopLevel = false;
            pnlSadrzaj.Controls.Add(frmPoslovniPartneri);
            frmPoslovniPartneri.Show();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            pnlOznaka.Height = btnPoslovniPartneri.Height;
            pnlOznaka.Top = btnZaposlenici.Top;
            bojanjeTekstaGumba(sender, e);

            pnlSadrzaj.Controls.Clear();
            frmZaposlenici frmZaposlenici = new frmZaposlenici(pnlSadrzaj);
            frmZaposlenici.TopLevel = false;
            pnlSadrzaj.Controls.Add(frmZaposlenici);
            frmZaposlenici.Show();
        }


        private void btnLokacija_Click(object sender, EventArgs e)
        {
            pnlOznaka.Height = btnPoslovniPartneri.Height;
            pnlOznaka.Top = btnLokacija.Top;
            bojanjeTekstaGumba(sender, e);

            pnlSadrzaj.Controls.Clear();
            frmGradDrzava frmGradDrzava = new frmGradDrzava(pnlSadrzaj);
            frmGradDrzava.TopLevel = false;
            pnlSadrzaj.Controls.Add(frmGradDrzava);
            frmGradDrzava.Show();
        }

        private void btnDokumentiUlaza_Click(object sender, EventArgs e)
        {
            pnlOznaka.Height = btnDokumentiUlaza.Height;
            pnlOznaka.Top = btnDokumentiUlaza.Top;
            bojanjeTekstaGumba(sender, e);

            pnlSadrzaj.Controls.Clear();
            frmPrikazDokumenataUlaza frmPrikazDokumenataUlaza = new frmPrikazDokumenataUlaza(pnlSadrzaj);
            frmPrikazDokumenataUlaza.TopLevel = false;
            pnlSadrzaj.Controls.Add(frmPrikazDokumenataUlaza);
            frmPrikazDokumenataUlaza.Show();
        }


        private void btnDokumentiIzlaza_Click(object sender, EventArgs e)
        {
            pnlOznaka.Height = btnDokumentiIzlaza.Height;
            pnlOznaka.Top = btnDokumentiIzlaza.Top;
            bojanjeTekstaGumba(sender, e);

            pnlSadrzaj.Controls.Clear();
            frmPrikazDokumenataIzlaza frmPrikazDokumenataIzlaza = new frmPrikazDokumenataIzlaza(pnlSadrzaj);
            frmPrikazDokumenataIzlaza.TopLevel = false;
            pnlSadrzaj.Controls.Add(frmPrikazDokumenataIzlaza);
            frmPrikazDokumenataIzlaza.Show();
        }




        private void bojanjeTekstaGumba(object sender, EventArgs e)
        {
            btnArtikli.ForeColor = Color.White;
            btnPoslovniPartneri.ForeColor = Color.White;
            btnZaposlenici.ForeColor = Color.White;
            btnOaplikaciji.ForeColor = Color.White;
            btnLokacija.ForeColor = Color.White;
            btnDokumentiIzlaza.ForeColor = Color.White;
            btnDokumentiUlaza.ForeColor = Color.White;

            Button gumb = sender as Button;
            if(pnlOznaka.Top == gumb.Top)
            {
                gumb.ForeColor = Color.Crimson;
            }
            else
            {
                gumb.ForeColor = Color.White;
            }
        }

        private void btnMinimiziraj_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlNaslov_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlNaslov_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlNaslov_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

    }
}
