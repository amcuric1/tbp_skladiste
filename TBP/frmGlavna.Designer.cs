namespace TBP
{
    partial class frmGlavna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavna));
            this.pnlNaslov = new System.Windows.Forms.Panel();
            this.pnlForma = new System.Windows.Forms.Panel();
            this.btnMinimiziraj = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.pnlIzbornik = new System.Windows.Forms.Panel();
            this.btnDokumentiIzlaza = new System.Windows.Forms.Button();
            this.btnDokumentiUlaza = new System.Windows.Forms.Button();
            this.btnLokacija = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnOaplikaciji = new System.Windows.Forms.Button();
            this.btnPoslovniPartneri = new System.Windows.Forms.Button();
            this.btnArtikli = new System.Windows.Forms.Button();
            this.pnlSadrzaj = new System.Windows.Forms.Panel();
            this.pnlOznaka = new System.Windows.Forms.Panel();
            this.pnlNaslov.SuspendLayout();
            this.pnlForma.SuspendLayout();
            this.pnlIzbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNaslov
            // 
            this.pnlNaslov.AccessibleName = "";
            this.pnlNaslov.BackColor = System.Drawing.Color.Crimson;
            this.pnlNaslov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNaslov.Controls.Add(this.pnlForma);
            this.pnlNaslov.Controls.Add(this.lblNaslov);
            this.pnlNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNaslov.Location = new System.Drawing.Point(0, 0);
            this.pnlNaslov.Name = "pnlNaslov";
            this.pnlNaslov.Size = new System.Drawing.Size(950, 96);
            this.pnlNaslov.TabIndex = 1;
            this.pnlNaslov.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNaslov_MouseDown);
            this.pnlNaslov.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlNaslov_MouseMove);
            this.pnlNaslov.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlNaslov_MouseUp);
            // 
            // pnlForma
            // 
            this.pnlForma.Controls.Add(this.btnMinimiziraj);
            this.pnlForma.Controls.Add(this.btnIzlaz);
            this.pnlForma.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForma.Location = new System.Drawing.Point(861, 0);
            this.pnlForma.Name = "pnlForma";
            this.pnlForma.Size = new System.Drawing.Size(87, 94);
            this.pnlForma.TabIndex = 0;
            // 
            // btnMinimiziraj
            // 
            this.btnMinimiziraj.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnMinimiziraj.FlatAppearance.BorderSize = 0;
            this.btnMinimiziraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimiziraj.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimiziraj.ForeColor = System.Drawing.Color.White;
            this.btnMinimiziraj.Location = new System.Drawing.Point(3, 11);
            this.btnMinimiziraj.Name = "btnMinimiziraj";
            this.btnMinimiziraj.Size = new System.Drawing.Size(31, 35);
            this.btnMinimiziraj.TabIndex = 8;
            this.btnMinimiziraj.Text = "–";
            this.btnMinimiziraj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimiziraj.UseVisualStyleBackColor = true;
            this.btnMinimiziraj.Click += new System.EventHandler(this.btnMinimiziraj_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzlaz.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaz.ForeColor = System.Drawing.Color.White;
            this.btnIzlaz.Location = new System.Drawing.Point(40, 11);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(31, 35);
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.Text = "X";
            this.btnIzlaz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(187, 28);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNaslov.Size = new System.Drawing.Size(574, 38);
            this.lblNaslov.TabIndex = 7;
            this.lblNaslov.Text = "Aplikacija za skladištenje proizvoda";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNaslov.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNaslov_MouseDown);
            this.lblNaslov.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlNaslov_MouseMove);
            this.lblNaslov.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlNaslov_MouseUp);
            // 
            // pnlIzbornik
            // 
            this.pnlIzbornik.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnlIzbornik.Controls.Add(this.pnlOznaka);
            this.pnlIzbornik.Controls.Add(this.btnDokumentiIzlaza);
            this.pnlIzbornik.Controls.Add(this.btnDokumentiUlaza);
            this.pnlIzbornik.Controls.Add(this.btnLokacija);
            this.pnlIzbornik.Controls.Add(this.btnZaposlenici);
            this.pnlIzbornik.Controls.Add(this.btnOaplikaciji);
            this.pnlIzbornik.Controls.Add(this.btnPoslovniPartneri);
            this.pnlIzbornik.Controls.Add(this.btnArtikli);
            this.pnlIzbornik.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzbornik.Location = new System.Drawing.Point(0, 96);
            this.pnlIzbornik.Name = "pnlIzbornik";
            this.pnlIzbornik.Size = new System.Drawing.Size(195, 504);
            this.pnlIzbornik.TabIndex = 2;
            // 
            // btnDokumentiIzlaza
            // 
            this.btnDokumentiIzlaza.FlatAppearance.BorderSize = 0;
            this.btnDokumentiIzlaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDokumentiIzlaza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDokumentiIzlaza.ForeColor = System.Drawing.Color.White;
            this.btnDokumentiIzlaza.Image = ((System.Drawing.Image)(resources.GetObject("btnDokumentiIzlaza.Image")));
            this.btnDokumentiIzlaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDokumentiIzlaza.Location = new System.Drawing.Point(0, 258);
            this.btnDokumentiIzlaza.Name = "btnDokumentiIzlaza";
            this.btnDokumentiIzlaza.Size = new System.Drawing.Size(195, 40);
            this.btnDokumentiIzlaza.TabIndex = 11;
            this.btnDokumentiIzlaza.Text = "            Dokumenti izlaza";
            this.btnDokumentiIzlaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDokumentiIzlaza.UseVisualStyleBackColor = false;
            this.btnDokumentiIzlaza.Click += new System.EventHandler(this.btnDokumentiIzlaza_Click);
            // 
            // btnDokumentiUlaza
            // 
            this.btnDokumentiUlaza.FlatAppearance.BorderSize = 0;
            this.btnDokumentiUlaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDokumentiUlaza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDokumentiUlaza.ForeColor = System.Drawing.Color.White;
            this.btnDokumentiUlaza.Image = ((System.Drawing.Image)(resources.GetObject("btnDokumentiUlaza.Image")));
            this.btnDokumentiUlaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDokumentiUlaza.Location = new System.Drawing.Point(0, 212);
            this.btnDokumentiUlaza.Name = "btnDokumentiUlaza";
            this.btnDokumentiUlaza.Size = new System.Drawing.Size(195, 40);
            this.btnDokumentiUlaza.TabIndex = 10;
            this.btnDokumentiUlaza.Text = "            Dokumenti ulaza";
            this.btnDokumentiUlaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDokumentiUlaza.UseVisualStyleBackColor = false;
            this.btnDokumentiUlaza.Click += new System.EventHandler(this.btnDokumentiUlaza_Click);
            // 
            // btnLokacija
            // 
            this.btnLokacija.FlatAppearance.BorderSize = 0;
            this.btnLokacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLokacija.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLokacija.ForeColor = System.Drawing.Color.White;
            this.btnLokacija.Image = ((System.Drawing.Image)(resources.GetObject("btnLokacija.Image")));
            this.btnLokacija.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLokacija.Location = new System.Drawing.Point(0, 358);
            this.btnLokacija.Name = "btnLokacija";
            this.btnLokacija.Size = new System.Drawing.Size(195, 40);
            this.btnLokacija.TabIndex = 8;
            this.btnLokacija.Text = "            Lokacija";
            this.btnLokacija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLokacija.UseVisualStyleBackColor = false;
            this.btnLokacija.Click += new System.EventHandler(this.btnLokacija_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.FlatAppearance.BorderSize = 0;
            this.btnZaposlenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaposlenici.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposlenici.ForeColor = System.Drawing.Color.White;
            this.btnZaposlenici.Image = ((System.Drawing.Image)(resources.GetObject("btnZaposlenici.Image")));
            this.btnZaposlenici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZaposlenici.Location = new System.Drawing.Point(0, 166);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(195, 40);
            this.btnZaposlenici.TabIndex = 5;
            this.btnZaposlenici.Text = "            Zaposlenici";
            this.btnZaposlenici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZaposlenici.UseVisualStyleBackColor = false;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // btnOaplikaciji
            // 
            this.btnOaplikaciji.FlatAppearance.BorderSize = 0;
            this.btnOaplikaciji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOaplikaciji.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOaplikaciji.ForeColor = System.Drawing.Color.White;
            this.btnOaplikaciji.Image = ((System.Drawing.Image)(resources.GetObject("btnOaplikaciji.Image")));
            this.btnOaplikaciji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOaplikaciji.Location = new System.Drawing.Point(0, 23);
            this.btnOaplikaciji.Name = "btnOaplikaciji";
            this.btnOaplikaciji.Size = new System.Drawing.Size(195, 40);
            this.btnOaplikaciji.TabIndex = 4;
            this.btnOaplikaciji.Text = "            O aplikaciji";
            this.btnOaplikaciji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOaplikaciji.UseVisualStyleBackColor = true;
            this.btnOaplikaciji.Click += new System.EventHandler(this.btnOaplikaciji_Click);
            // 
            // btnPoslovniPartneri
            // 
            this.btnPoslovniPartneri.FlatAppearance.BorderSize = 0;
            this.btnPoslovniPartneri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoslovniPartneri.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoslovniPartneri.ForeColor = System.Drawing.Color.White;
            this.btnPoslovniPartneri.Image = ((System.Drawing.Image)(resources.GetObject("btnPoslovniPartneri.Image")));
            this.btnPoslovniPartneri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoslovniPartneri.Location = new System.Drawing.Point(0, 115);
            this.btnPoslovniPartneri.Name = "btnPoslovniPartneri";
            this.btnPoslovniPartneri.Size = new System.Drawing.Size(195, 40);
            this.btnPoslovniPartneri.TabIndex = 1;
            this.btnPoslovniPartneri.Text = "            Poslovni partneri";
            this.btnPoslovniPartneri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoslovniPartneri.UseVisualStyleBackColor = true;
            this.btnPoslovniPartneri.Click += new System.EventHandler(this.btnPoslovniPartneri_Click);
            // 
            // btnArtikli
            // 
            this.btnArtikli.FlatAppearance.BorderSize = 0;
            this.btnArtikli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikli.ForeColor = System.Drawing.Color.White;
            this.btnArtikli.Image = ((System.Drawing.Image)(resources.GetObject("btnArtikli.Image")));
            this.btnArtikli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtikli.Location = new System.Drawing.Point(0, 68);
            this.btnArtikli.Name = "btnArtikli";
            this.btnArtikli.Size = new System.Drawing.Size(195, 40);
            this.btnArtikli.TabIndex = 0;
            this.btnArtikli.Text = "            Artikli";
            this.btnArtikli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtikli.UseVisualStyleBackColor = true;
            this.btnArtikli.Click += new System.EventHandler(this.btnArtikli_Click);
            // 
            // pnlSadrzaj
            // 
            this.pnlSadrzaj.BackColor = System.Drawing.Color.White;
            this.pnlSadrzaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSadrzaj.Location = new System.Drawing.Point(195, 96);
            this.pnlSadrzaj.Name = "pnlSadrzaj";
            this.pnlSadrzaj.Size = new System.Drawing.Size(755, 504);
            this.pnlSadrzaj.TabIndex = 3;
            // 
            // pnlOznaka
            // 
            this.pnlOznaka.BackColor = System.Drawing.Color.Crimson;
            this.pnlOznaka.Location = new System.Drawing.Point(185, 23);
            this.pnlOznaka.Name = "pnlOznaka";
            this.pnlOznaka.Size = new System.Drawing.Size(10, 40);
            this.pnlOznaka.TabIndex = 12;
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.pnlSadrzaj);
            this.Controls.Add(this.pnlIzbornik);
            this.Controls.Add(this.pnlNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlNaslov.ResumeLayout(false);
            this.pnlNaslov.PerformLayout();
            this.pnlForma.ResumeLayout(false);
            this.pnlIzbornik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNaslov;
        private System.Windows.Forms.Panel pnlIzbornik;
        private System.Windows.Forms.Button btnOaplikaciji;
        private System.Windows.Forms.Button btnPoslovniPartneri;
        private System.Windows.Forms.Button btnArtikli;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Panel pnlSadrzaj;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnLokacija;
        private System.Windows.Forms.Button btnMinimiziraj;
        private System.Windows.Forms.Panel pnlForma;
        private System.Windows.Forms.Button btnDokumentiIzlaza;
        private System.Windows.Forms.Button btnDokumentiUlaza;
        private System.Windows.Forms.Panel pnlOznaka;
    }
}

