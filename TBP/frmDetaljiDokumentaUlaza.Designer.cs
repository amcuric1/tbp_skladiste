namespace TBP
{
    partial class frmDetaljiDokumentaUlaza
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblPoslovniPartner = new System.Windows.Forms.Label();
            this.dgvStavkeDokumentaUlaza = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblArtikliDokumenta = new System.Windows.Forms.Label();
            this.lblPrikazZ = new System.Windows.Forms.Label();
            this.lblPrikazPP = new System.Windows.Forms.Label();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumentaUlaza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.Black;
            this.lblDatum.Location = new System.Drawing.Point(358, 32);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(60, 18);
            this.lblDatum.TabIndex = 57;
            this.lblDatum.Text = "Datum:";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaposlenik.ForeColor = System.Drawing.Color.Black;
            this.lblZaposlenik.Location = new System.Drawing.Point(23, 310);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(79, 17);
            this.lblZaposlenik.TabIndex = 55;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.Crimson;
            this.lblNaziv.Location = new System.Drawing.Point(71, 22);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(83, 28);
            this.lblNaziv.TabIndex = 52;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblPoslovniPartner
            // 
            this.lblPoslovniPartner.AutoSize = true;
            this.lblPoslovniPartner.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoslovniPartner.ForeColor = System.Drawing.Color.Black;
            this.lblPoslovniPartner.Location = new System.Drawing.Point(23, 337);
            this.lblPoslovniPartner.Name = "lblPoslovniPartner";
            this.lblPoslovniPartner.Size = new System.Drawing.Size(116, 17);
            this.lblPoslovniPartner.TabIndex = 54;
            this.lblPoslovniPartner.Text = "Poslovni partner:";
            // 
            // dgvStavkeDokumentaUlaza
            // 
            this.dgvStavkeDokumentaUlaza.AllowUserToAddRows = false;
            this.dgvStavkeDokumentaUlaza.AllowUserToDeleteRows = false;
            this.dgvStavkeDokumentaUlaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeDokumentaUlaza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.jedinicnaCijena,
            this.kolicina,
            this.ukupnaCijena});
            this.dgvStavkeDokumentaUlaza.Location = new System.Drawing.Point(26, 110);
            this.dgvStavkeDokumentaUlaza.MultiSelect = false;
            this.dgvStavkeDokumentaUlaza.Name = "dgvStavkeDokumentaUlaza";
            this.dgvStavkeDokumentaUlaza.ReadOnly = true;
            this.dgvStavkeDokumentaUlaza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeDokumentaUlaza.Size = new System.Drawing.Size(489, 150);
            this.dgvStavkeDokumentaUlaza.TabIndex = 58;
            // 
            // naziv
            // 
            this.naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // jedinicnaCijena
            // 
            this.jedinicnaCijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.jedinicnaCijena.HeaderText = "Jedinična cijena";
            this.jedinicnaCijena.Name = "jedinicnaCijena";
            this.jedinicnaCijena.ReadOnly = true;
            this.jedinicnaCijena.Width = 99;
            // 
            // kolicina
            // 
            this.kolicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            this.kolicina.Width = 69;
            // 
            // ukupnaCijena
            // 
            this.ukupnaCijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ukupnaCijena.HeaderText = "Ukupna cijena";
            this.ukupnaCijena.Name = "ukupnaCijena";
            this.ukupnaCijena.ReadOnly = true;
            this.ukupnaCijena.Width = 93;
            // 
            // lblArtikliDokumenta
            // 
            this.lblArtikliDokumenta.AutoSize = true;
            this.lblArtikliDokumenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikliDokumenta.ForeColor = System.Drawing.Color.Black;
            this.lblArtikliDokumenta.Location = new System.Drawing.Point(23, 90);
            this.lblArtikliDokumenta.Name = "lblArtikliDokumenta";
            this.lblArtikliDokumenta.Size = new System.Drawing.Size(126, 17);
            this.lblArtikliDokumenta.TabIndex = 59;
            this.lblArtikliDokumenta.Text = "Artikli dokumenta:";
            // 
            // lblPrikazZ
            // 
            this.lblPrikazZ.AutoSize = true;
            this.lblPrikazZ.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikazZ.ForeColor = System.Drawing.Color.Black;
            this.lblPrikazZ.Location = new System.Drawing.Point(108, 310);
            this.lblPrikazZ.Name = "lblPrikazZ";
            this.lblPrikazZ.Size = new System.Drawing.Size(0, 17);
            this.lblPrikazZ.TabIndex = 60;
            // 
            // lblPrikazPP
            // 
            this.lblPrikazPP.AutoSize = true;
            this.lblPrikazPP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikazPP.ForeColor = System.Drawing.Color.Black;
            this.lblPrikazPP.Location = new System.Drawing.Point(145, 337);
            this.lblPrikazPP.Name = "lblPrikazPP";
            this.lblPrikazPP.Size = new System.Drawing.Size(0, 17);
            this.lblPrikazPP.TabIndex = 61;
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnaCijena.ForeColor = System.Drawing.Color.Black;
            this.lblUkupnaCijena.Location = new System.Drawing.Point(429, 277);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(0, 17);
            this.lblUkupnaCijena.TabIndex = 73;
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupno.ForeColor = System.Drawing.Color.Black;
            this.lblUkupno.Location = new System.Drawing.Point(368, 277);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(61, 17);
            this.lblUkupno.TabIndex = 72;
            this.lblUkupno.Text = "Ukupno:";
            // 
            // frmDetaljiDokumentaUlaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 378);
            this.Controls.Add(this.lblUkupnaCijena);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.lblPrikazPP);
            this.Controls.Add(this.lblPrikazZ);
            this.Controls.Add(this.lblArtikliDokumenta);
            this.Controls.Add(this.dgvStavkeDokumentaUlaza);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblPoslovniPartner);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetaljiDokumentaUlaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji dokumenta ulaza";
            this.Load += new System.EventHandler(this.frmDetaljiDokumentaUlaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumentaUlaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblPoslovniPartner;
        private System.Windows.Forms.DataGridView dgvStavkeDokumentaUlaza;
        private System.Windows.Forms.Label lblArtikliDokumenta;
        private System.Windows.Forms.Label lblPrikazZ;
        private System.Windows.Forms.Label lblPrikazPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnaCijena;
        private System.Windows.Forms.Label lblUkupnaCijena;
        private System.Windows.Forms.Label lblUkupno;
    }
}