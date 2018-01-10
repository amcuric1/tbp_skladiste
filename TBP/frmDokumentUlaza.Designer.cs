namespace TBP
{
    partial class frmDokumentUlaza
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDokumentUlaza));
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dgvDodaniArtikli = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboArtikli = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.lboxPotrebniArtikli = new System.Windows.Forms.ListBox();
            this.lblPotrebniArtikli = new System.Windows.Forms.Label();
            this.lblDodavanjeArtikala = new System.Windows.Forms.Label();
            this.lblArtikli = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblDodaniArtikli = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbPomoc3 = new System.Windows.Forms.PictureBox();
            this.btnObrisiArtikl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodaniArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDatum.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpDatum.Location = new System.Drawing.Point(213, 53);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(131, 20);
            this.dtpDatum.TabIndex = 50;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.Black;
            this.lblDatum.Location = new System.Drawing.Point(154, 53);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 51;
            this.lblDatum.Text = "Datum";
            // 
            // pbPomoc1
            // 
            this.pbPomoc1.Image = ((System.Drawing.Image)(resources.GetObject("pbPomoc1.Image")));
            this.pbPomoc1.Location = new System.Drawing.Point(350, 81);
            this.pbPomoc1.Name = "pbPomoc1";
            this.pbPomoc1.Size = new System.Drawing.Size(25, 21);
            this.pbPomoc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPomoc1.TabIndex = 49;
            this.pbPomoc1.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPomoc1, "Ukoliko ne postoje željeli zaposlenici, potrebno ih je dodati u izborniku klikom " +
        "na \"Zaposlenici\"");
            this.pbPomoc1.WaitOnLoad = true;
            // 
            // comboZaposlenici
            // 
            this.comboZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboZaposlenici.ForeColor = System.Drawing.Color.Black;
            this.comboZaposlenici.FormattingEnabled = true;
            this.comboZaposlenici.Location = new System.Drawing.Point(213, 81);
            this.comboZaposlenici.Name = "comboZaposlenici";
            this.comboZaposlenici.Size = new System.Drawing.Size(131, 21);
            this.comboZaposlenici.TabIndex = 48;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaposlenik.ForeColor = System.Drawing.Color.Black;
            this.lblZaposlenik.Location = new System.Drawing.Point(132, 82);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(75, 17);
            this.lblZaposlenik.TabIndex = 47;
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // pbPomoc2
            // 
            this.pbPomoc2.Image = ((System.Drawing.Image)(resources.GetObject("pbPomoc2.Image")));
            this.pbPomoc2.Location = new System.Drawing.Point(350, 113);
            this.pbPomoc2.Name = "pbPomoc2";
            this.pbPomoc2.Size = new System.Drawing.Size(25, 21);
            this.pbPomoc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPomoc2.TabIndex = 46;
            this.pbPomoc2.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPomoc2, "Ukoliko ne postoje željeli poslovni partneri, potrebno ih je dodati u izborniku k" +
        "likom na \"Poslovni partneri\"");
            this.pbPomoc2.WaitOnLoad = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNaziv.ForeColor = System.Drawing.Color.Black;
            this.txtNaziv.Location = new System.Drawing.Point(213, 24);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(131, 20);
            this.txtNaziv.TabIndex = 42;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.Black;
            this.lblNaziv.Location = new System.Drawing.Point(163, 27);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 17);
            this.lblNaziv.TabIndex = 41;
            this.lblNaziv.Text = "Naziv";
            // 
            // comboPoslovniPartneri
            // 
            this.comboPoslovniPartneri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboPoslovniPartneri.ForeColor = System.Drawing.Color.Black;
            this.comboPoslovniPartneri.FormattingEnabled = true;
            this.comboPoslovniPartneri.Location = new System.Drawing.Point(213, 113);
            this.comboPoslovniPartneri.Name = "comboPoslovniPartneri";
            this.comboPoslovniPartneri.Size = new System.Drawing.Size(131, 21);
            this.comboPoslovniPartneri.TabIndex = 45;
            // 
            // lblPoslovniPartner
            // 
            this.lblPoslovniPartner.AutoSize = true;
            this.lblPoslovniPartner.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoslovniPartner.ForeColor = System.Drawing.Color.Black;
            this.lblPoslovniPartner.Location = new System.Drawing.Point(95, 114);
            this.lblPoslovniPartner.Name = "lblPoslovniPartner";
            this.lblPoslovniPartner.Size = new System.Drawing.Size(112, 17);
            this.lblPoslovniPartner.TabIndex = 44;
            this.lblPoslovniPartner.Text = "Poslovni partner";
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.LightGray;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.Location = new System.Drawing.Point(202, 574);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(131, 34);
            this.btnSpremi.TabIndex = 52;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            this.btnSpremi.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnSpremi.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // dgvDodaniArtikli
            // 
            this.dgvDodaniArtikli.AllowUserToAddRows = false;
            this.dgvDodaniArtikli.AllowUserToDeleteRows = false;
            this.dgvDodaniArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDodaniArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Kolicina});
            this.dgvDodaniArtikli.Location = new System.Drawing.Point(63, 370);
            this.dgvDodaniArtikli.MultiSelect = false;
            this.dgvDodaniArtikli.Name = "dgvDodaniArtikli";
            this.dgvDodaniArtikli.ReadOnly = true;
            this.dgvDodaniArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDodaniArtikli.Size = new System.Drawing.Size(392, 121);
            this.dgvDodaniArtikli.TabIndex = 53;
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
            // Kolicina
            // 
            this.Kolicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // comboArtikli
            // 
            this.comboArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboArtikli.ForeColor = System.Drawing.Color.Black;
            this.comboArtikli.FormattingEnabled = true;
            this.comboArtikli.Location = new System.Drawing.Point(324, 181);
            this.comboArtikli.Name = "comboArtikli";
            this.comboArtikli.Size = new System.Drawing.Size(131, 21);
            this.comboArtikli.TabIndex = 54;
            // 
            // txtKolicina
            // 
            this.txtKolicina.ForeColor = System.Drawing.Color.Black;
            this.txtKolicina.Location = new System.Drawing.Point(324, 212);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(131, 20);
            this.txtKolicina.TabIndex = 55;
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.BackColor = System.Drawing.Color.LightGray;
            this.btnDodajArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajArtikl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajArtikl.Location = new System.Drawing.Point(324, 266);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(131, 34);
            this.btnDodajArtikl.TabIndex = 56;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = false;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            this.btnDodajArtikl.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnDodajArtikl.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // lboxPotrebniArtikli
            // 
            this.lboxPotrebniArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lboxPotrebniArtikli.ForeColor = System.Drawing.Color.Black;
            this.lboxPotrebniArtikli.FormattingEnabled = true;
            this.lboxPotrebniArtikli.Location = new System.Drawing.Point(63, 181);
            this.lboxPotrebniArtikli.Name = "lboxPotrebniArtikli";
            this.lboxPotrebniArtikli.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lboxPotrebniArtikli.Size = new System.Drawing.Size(164, 121);
            this.lboxPotrebniArtikli.TabIndex = 57;
            // 
            // lblPotrebniArtikli
            // 
            this.lblPotrebniArtikli.AutoSize = true;
            this.lblPotrebniArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotrebniArtikli.ForeColor = System.Drawing.Color.Black;
            this.lblPotrebniArtikli.Location = new System.Drawing.Point(60, 161);
            this.lblPotrebniArtikli.Name = "lblPotrebniArtikli";
            this.lblPotrebniArtikli.Size = new System.Drawing.Size(104, 17);
            this.lblPotrebniArtikli.TabIndex = 58;
            this.lblPotrebniArtikli.Text = "Potrebni artikli:";
            // 
            // lblDodavanjeArtikala
            // 
            this.lblDodavanjeArtikala.AutoSize = true;
            this.lblDodavanjeArtikala.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodavanjeArtikala.ForeColor = System.Drawing.Color.Black;
            this.lblDodavanjeArtikala.Location = new System.Drawing.Point(317, 161);
            this.lblDodavanjeArtikala.Name = "lblDodavanjeArtikala";
            this.lblDodavanjeArtikala.Size = new System.Drawing.Size(138, 17);
            this.lblDodavanjeArtikala.TabIndex = 59;
            this.lblDodavanjeArtikala.Text = "Dodavanje artikala:";
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikli.ForeColor = System.Drawing.Color.Black;
            this.lblArtikli.Location = new System.Drawing.Point(276, 181);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(42, 17);
            this.lblArtikli.TabIndex = 60;
            this.lblArtikli.Text = "Artikli";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.ForeColor = System.Drawing.Color.Black;
            this.lblKolicina.Location = new System.Drawing.Point(259, 213);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(59, 17);
            this.lblKolicina.TabIndex = 61;
            this.lblKolicina.Text = "Kolicina";
            // 
            // lblDodaniArtikli
            // 
            this.lblDodaniArtikli.AutoSize = true;
            this.lblDodaniArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodaniArtikli.ForeColor = System.Drawing.Color.Black;
            this.lblDodaniArtikli.Location = new System.Drawing.Point(60, 350);
            this.lblDodaniArtikli.Name = "lblDodaniArtikli";
            this.lblDodaniArtikli.Size = new System.Drawing.Size(98, 17);
            this.lblDodaniArtikli.TabIndex = 62;
            this.lblDodaniArtikli.Text = "Dodani artikli:";
            // 
            // pbPomoc3
            // 
            this.pbPomoc3.Image = ((System.Drawing.Image)(resources.GetObject("pbPomoc3.Image")));
            this.pbPomoc3.Location = new System.Drawing.Point(233, 281);
            this.pbPomoc3.Name = "pbPomoc3";
            this.pbPomoc3.Size = new System.Drawing.Size(25, 21);
            this.pbPomoc3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPomoc3.TabIndex = 63;
            this.pbPomoc3.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPomoc3, "Prikazani su artikli čija je količina na skladištu manja od minimalne dopuštene k" +
        "oličine");
            this.pbPomoc3.WaitOnLoad = true;
            // 
            // btnObrisiArtikl
            // 
            this.btnObrisiArtikl.BackColor = System.Drawing.Color.LightGray;
            this.btnObrisiArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiArtikl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiArtikl.Location = new System.Drawing.Point(202, 497);
            this.btnObrisiArtikl.Name = "btnObrisiArtikl";
            this.btnObrisiArtikl.Size = new System.Drawing.Size(131, 34);
            this.btnObrisiArtikl.TabIndex = 64;
            this.btnObrisiArtikl.Text = "Obriši artikl";
            this.btnObrisiArtikl.UseVisualStyleBackColor = false;
            this.btnObrisiArtikl.Click += new System.EventHandler(this.btnObrisiArtikl_Click);
            this.btnObrisiArtikl.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnObrisiArtikl.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // frmDokumentUlaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 620);
            this.Controls.Add(this.btnObrisiArtikl);
            this.Controls.Add(this.pbPomoc3);
            this.Controls.Add(this.lblDodaniArtikli);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.lblDodavanjeArtikala);
            this.Controls.Add(this.lblPotrebniArtikli);
            this.Controls.Add(this.lboxPotrebniArtikli);
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
            this.Name = "frmDokumentUlaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dokument ulaza";
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodaniArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DataGridView dgvDodaniArtikli;
        private System.Windows.Forms.ComboBox comboArtikli;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.ListBox lboxPotrebniArtikli;
        private System.Windows.Forms.Label lblPotrebniArtikli;
        private System.Windows.Forms.Label lblDodavanjeArtikala;
        private System.Windows.Forms.Label lblArtikli;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDodaniArtikli;
        private System.Windows.Forms.PictureBox pbPomoc3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.Button btnObrisiArtikl;
    }
}