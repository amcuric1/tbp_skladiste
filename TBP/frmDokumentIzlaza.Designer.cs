namespace TBP
{
    partial class frmDokumentIzlaza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDokumentIzlaza));
            this.lblDodaniArtikli = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblArtikli = new System.Windows.Forms.Label();
            this.lblDodavanjeArtikala = new System.Windows.Forms.Label();
            this.lblArtikl = new System.Windows.Forms.Label();
            this.lboxVisakArtikli = new System.Windows.Forms.ListBox();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.comboArtikli = new System.Windows.Forms.ComboBox();
            this.dgvDodaniArtikli = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.pbPomoc1 = new System.Windows.Forms.PictureBox();
            this.comboZaposlenici = new System.Windows.Forms.ComboBox();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.pbPomoc2 = new System.Windows.Forms.PictureBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.comboPoslovniPartneri = new System.Windows.Forms.ComboBox();
            this.lblPoslovniPartner = new System.Windows.Forms.Label();
            this.btnObrisiArtikl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodaniArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDodaniArtikli
            // 
            this.lblDodaniArtikli.AutoSize = true;
            this.lblDodaniArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodaniArtikli.ForeColor = System.Drawing.Color.Black;
            this.lblDodaniArtikli.Location = new System.Drawing.Point(67, 344);
            this.lblDodaniArtikli.Name = "lblDodaniArtikli";
            this.lblDodaniArtikli.Size = new System.Drawing.Size(98, 17);
            this.lblDodaniArtikli.TabIndex = 84;
            this.lblDodaniArtikli.Text = "Dodani artikli:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.ForeColor = System.Drawing.Color.Black;
            this.lblKolicina.Location = new System.Drawing.Point(266, 207);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(59, 17);
            this.lblKolicina.TabIndex = 83;
            this.lblKolicina.Text = "Kolicina";
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikli.ForeColor = System.Drawing.Color.Black;
            this.lblArtikli.Location = new System.Drawing.Point(283, 175);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(42, 17);
            this.lblArtikli.TabIndex = 82;
            this.lblArtikli.Text = "Artikli";
            // 
            // lblDodavanjeArtikala
            // 
            this.lblDodavanjeArtikala.AutoSize = true;
            this.lblDodavanjeArtikala.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodavanjeArtikala.ForeColor = System.Drawing.Color.Black;
            this.lblDodavanjeArtikala.Location = new System.Drawing.Point(324, 155);
            this.lblDodavanjeArtikala.Name = "lblDodavanjeArtikala";
            this.lblDodavanjeArtikala.Size = new System.Drawing.Size(138, 17);
            this.lblDodavanjeArtikala.TabIndex = 81;
            this.lblDodavanjeArtikala.Text = "Dodavanje artikala:";
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikl.ForeColor = System.Drawing.Color.Black;
            this.lblArtikl.Location = new System.Drawing.Point(67, 155);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(145, 17);
            this.lblArtikl.TabIndex = 80;
            this.lblArtikl.Text = "Artikli kojih ima viška:";
            // 
            // lboxVisakArtikli
            // 
            this.lboxVisakArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lboxVisakArtikli.ForeColor = System.Drawing.Color.Black;
            this.lboxVisakArtikli.FormattingEnabled = true;
            this.lboxVisakArtikli.Location = new System.Drawing.Point(70, 175);
            this.lboxVisakArtikli.Name = "lboxVisakArtikli";
            this.lboxVisakArtikli.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lboxVisakArtikli.Size = new System.Drawing.Size(164, 121);
            this.lboxVisakArtikli.TabIndex = 79;
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.BackColor = System.Drawing.Color.LightGray;
            this.btnDodajArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajArtikl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajArtikl.Location = new System.Drawing.Point(331, 260);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(131, 34);
            this.btnDodajArtikl.TabIndex = 78;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = false;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            this.btnDodajArtikl.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnDodajArtikl.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // txtKolicina
            // 
            this.txtKolicina.ForeColor = System.Drawing.Color.Black;
            this.txtKolicina.Location = new System.Drawing.Point(331, 206);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(131, 20);
            this.txtKolicina.TabIndex = 77;
            // 
            // comboArtikli
            // 
            this.comboArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboArtikli.ForeColor = System.Drawing.Color.Black;
            this.comboArtikli.FormattingEnabled = true;
            this.comboArtikli.Location = new System.Drawing.Point(331, 175);
            this.comboArtikli.Name = "comboArtikli";
            this.comboArtikli.Size = new System.Drawing.Size(131, 21);
            this.comboArtikli.TabIndex = 76;
            // 
            // dgvDodaniArtikli
            // 
            this.dgvDodaniArtikli.AllowUserToAddRows = false;
            this.dgvDodaniArtikli.AllowUserToDeleteRows = false;
            this.dgvDodaniArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDodaniArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.kolicina});
            this.dgvDodaniArtikli.Location = new System.Drawing.Point(70, 364);
            this.dgvDodaniArtikli.MultiSelect = false;
            this.dgvDodaniArtikli.Name = "dgvDodaniArtikli";
            this.dgvDodaniArtikli.ReadOnly = true;
            this.dgvDodaniArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDodaniArtikli.Size = new System.Drawing.Size(392, 121);
            this.dgvDodaniArtikli.TabIndex = 75;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.LightGray;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.Location = new System.Drawing.Point(194, 574);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(131, 34);
            this.btnSpremi.TabIndex = 74;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            this.btnSpremi.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnSpremi.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // dtpDatum
            // 
            this.dtpDatum.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDatum.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpDatum.Location = new System.Drawing.Point(220, 47);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(131, 20);
            this.dtpDatum.TabIndex = 72;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.Black;
            this.lblDatum.Location = new System.Drawing.Point(161, 47);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 73;
            this.lblDatum.Text = "Datum";
            // 
            // pbPomoc1
            // 
            this.pbPomoc1.Image = ((System.Drawing.Image)(resources.GetObject("pbPomoc1.Image")));
            this.pbPomoc1.Location = new System.Drawing.Point(357, 75);
            this.pbPomoc1.Name = "pbPomoc1";
            this.pbPomoc1.Size = new System.Drawing.Size(25, 21);
            this.pbPomoc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPomoc1.TabIndex = 71;
            this.pbPomoc1.TabStop = false;
            this.pbPomoc1.WaitOnLoad = true;
            // 
            // comboZaposlenici
            // 
            this.comboZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboZaposlenici.ForeColor = System.Drawing.Color.Black;
            this.comboZaposlenici.FormattingEnabled = true;
            this.comboZaposlenici.Location = new System.Drawing.Point(220, 75);
            this.comboZaposlenici.Name = "comboZaposlenici";
            this.comboZaposlenici.Size = new System.Drawing.Size(131, 21);
            this.comboZaposlenici.TabIndex = 70;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaposlenik.ForeColor = System.Drawing.Color.Black;
            this.lblZaposlenik.Location = new System.Drawing.Point(139, 76);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(75, 17);
            this.lblZaposlenik.TabIndex = 69;
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // pbPomoc2
            // 
            this.pbPomoc2.Image = ((System.Drawing.Image)(resources.GetObject("pbPomoc2.Image")));
            this.pbPomoc2.Location = new System.Drawing.Point(357, 107);
            this.pbPomoc2.Name = "pbPomoc2";
            this.pbPomoc2.Size = new System.Drawing.Size(25, 21);
            this.pbPomoc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPomoc2.TabIndex = 68;
            this.pbPomoc2.TabStop = false;
            this.pbPomoc2.WaitOnLoad = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNaziv.ForeColor = System.Drawing.Color.Black;
            this.txtNaziv.Location = new System.Drawing.Point(220, 18);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(131, 20);
            this.txtNaziv.TabIndex = 65;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.Black;
            this.lblNaziv.Location = new System.Drawing.Point(170, 21);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 17);
            this.lblNaziv.TabIndex = 64;
            this.lblNaziv.Text = "Naziv";
            // 
            // comboPoslovniPartneri
            // 
            this.comboPoslovniPartneri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboPoslovniPartneri.ForeColor = System.Drawing.Color.Black;
            this.comboPoslovniPartneri.FormattingEnabled = true;
            this.comboPoslovniPartneri.Location = new System.Drawing.Point(220, 107);
            this.comboPoslovniPartneri.Name = "comboPoslovniPartneri";
            this.comboPoslovniPartneri.Size = new System.Drawing.Size(131, 21);
            this.comboPoslovniPartneri.TabIndex = 67;
            // 
            // lblPoslovniPartner
            // 
            this.lblPoslovniPartner.AutoSize = true;
            this.lblPoslovniPartner.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoslovniPartner.ForeColor = System.Drawing.Color.Black;
            this.lblPoslovniPartner.Location = new System.Drawing.Point(102, 108);
            this.lblPoslovniPartner.Name = "lblPoslovniPartner";
            this.lblPoslovniPartner.Size = new System.Drawing.Size(112, 17);
            this.lblPoslovniPartner.TabIndex = 66;
            this.lblPoslovniPartner.Text = "Poslovni partner";
            // 
            // btnObrisiArtikl
            // 
            this.btnObrisiArtikl.BackColor = System.Drawing.Color.LightGray;
            this.btnObrisiArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiArtikl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiArtikl.Location = new System.Drawing.Point(194, 491);
            this.btnObrisiArtikl.Name = "btnObrisiArtikl";
            this.btnObrisiArtikl.Size = new System.Drawing.Size(131, 34);
            this.btnObrisiArtikl.TabIndex = 85;
            this.btnObrisiArtikl.Text = "Obriši artikl";
            this.btnObrisiArtikl.UseVisualStyleBackColor = false;
            this.btnObrisiArtikl.Click += new System.EventHandler(this.btnObrisiArtikl_Click);
            this.btnObrisiArtikl.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnObrisiArtikl.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // frmDokumentIzlaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 620);
            this.Controls.Add(this.btnObrisiArtikl);
            this.Controls.Add(this.lblDodaniArtikli);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.lblDodavanjeArtikala);
            this.Controls.Add(this.lblArtikl);
            this.Controls.Add(this.lboxVisakArtikli);
            this.Controls.Add(this.btnDodajArtikl);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.comboArtikli);
            this.Controls.Add(this.dgvDodaniArtikli);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.pbPomoc1);
            this.Controls.Add(this.comboZaposlenici);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.pbPomoc2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.comboPoslovniPartneri);
            this.Controls.Add(this.lblPoslovniPartner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDokumentIzlaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dokument izlaza";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodaniArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDodaniArtikli;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblArtikli;
        private System.Windows.Forms.Label lblDodavanjeArtikala;
        private System.Windows.Forms.Label lblArtikl;
        private System.Windows.Forms.ListBox lboxVisakArtikli;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.ComboBox comboArtikli;
        private System.Windows.Forms.DataGridView dgvDodaniArtikli;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.PictureBox pbPomoc1;
        private System.Windows.Forms.ComboBox comboZaposlenici;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.PictureBox pbPomoc2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.ComboBox comboPoslovniPartneri;
        private System.Windows.Forms.Label lblPoslovniPartner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.Button btnObrisiArtikl;
    }
}