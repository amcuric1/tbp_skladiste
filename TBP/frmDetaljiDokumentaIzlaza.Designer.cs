namespace TBP
{
    partial class frmDetaljiDokumentaIzlaza
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
            this.lblPrikazPP = new System.Windows.Forms.Label();
            this.lblPrikazZ = new System.Windows.Forms.Label();
            this.lblArtikliDokumenta = new System.Windows.Forms.Label();
            this.dgvStavkeDokumentaIzlaza = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblPoslovniPartner = new System.Windows.Forms.Label();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumentaIzlaza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrikazPP
            // 
            this.lblPrikazPP.AutoSize = true;
            this.lblPrikazPP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikazPP.ForeColor = System.Drawing.Color.Black;
            this.lblPrikazPP.Location = new System.Drawing.Point(146, 335);
            this.lblPrikazPP.Name = "lblPrikazPP";
            this.lblPrikazPP.Size = new System.Drawing.Size(0, 17);
            this.lblPrikazPP.TabIndex = 69;
            // 
            // lblPrikazZ
            // 
            this.lblPrikazZ.AutoSize = true;
            this.lblPrikazZ.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikazZ.ForeColor = System.Drawing.Color.Black;
            this.lblPrikazZ.Location = new System.Drawing.Point(109, 308);
            this.lblPrikazZ.Name = "lblPrikazZ";
            this.lblPrikazZ.Size = new System.Drawing.Size(0, 17);
            this.lblPrikazZ.TabIndex = 68;
            // 
            // lblArtikliDokumenta
            // 
            this.lblArtikliDokumenta.AutoSize = true;
            this.lblArtikliDokumenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikliDokumenta.ForeColor = System.Drawing.Color.Black;
            this.lblArtikliDokumenta.Location = new System.Drawing.Point(24, 95);
            this.lblArtikliDokumenta.Name = "lblArtikliDokumenta";
            this.lblArtikliDokumenta.Size = new System.Drawing.Size(126, 17);
            this.lblArtikliDokumenta.TabIndex = 67;
            this.lblArtikliDokumenta.Text = "Artikli dokumenta:";
            // 
            // dgvStavkeDokumentaIzlaza
            // 
            this.dgvStavkeDokumentaIzlaza.AllowUserToAddRows = false;
            this.dgvStavkeDokumentaIzlaza.AllowUserToDeleteRows = false;
            this.dgvStavkeDokumentaIzlaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeDokumentaIzlaza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvStavkeDokumentaIzlaza.Location = new System.Drawing.Point(27, 115);
            this.dgvStavkeDokumentaIzlaza.MultiSelect = false;
            this.dgvStavkeDokumentaIzlaza.Name = "dgvStavkeDokumentaIzlaza";
            this.dgvStavkeDokumentaIzlaza.ReadOnly = true;
            this.dgvStavkeDokumentaIzlaza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeDokumentaIzlaza.Size = new System.Drawing.Size(489, 150);
            this.dgvStavkeDokumentaIzlaza.TabIndex = 66;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Naziv";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Jedinična cijena";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 99;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Količina";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 69;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Ukupna cijena";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 93;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.Black;
            this.lblDatum.Location = new System.Drawing.Point(359, 37);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(60, 18);
            this.lblDatum.TabIndex = 65;
            this.lblDatum.Text = "Datum:";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaposlenik.ForeColor = System.Drawing.Color.Black;
            this.lblZaposlenik.Location = new System.Drawing.Point(24, 308);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(79, 17);
            this.lblZaposlenik.TabIndex = 64;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.Crimson;
            this.lblNaziv.Location = new System.Drawing.Point(72, 27);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(83, 28);
            this.lblNaziv.TabIndex = 62;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblPoslovniPartner
            // 
            this.lblPoslovniPartner.AutoSize = true;
            this.lblPoslovniPartner.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoslovniPartner.ForeColor = System.Drawing.Color.Black;
            this.lblPoslovniPartner.Location = new System.Drawing.Point(24, 335);
            this.lblPoslovniPartner.Name = "lblPoslovniPartner";
            this.lblPoslovniPartner.Size = new System.Drawing.Size(116, 17);
            this.lblPoslovniPartner.TabIndex = 63;
            this.lblPoslovniPartner.Text = "Poslovni partner:";
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnaCijena.ForeColor = System.Drawing.Color.Black;
            this.lblUkupnaCijena.Location = new System.Drawing.Point(432, 277);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(0, 17);
            this.lblUkupnaCijena.TabIndex = 71;
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupno.ForeColor = System.Drawing.Color.Black;
            this.lblUkupno.Location = new System.Drawing.Point(371, 277);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(61, 17);
            this.lblUkupno.TabIndex = 70;
            this.lblUkupno.Text = "Ukupno:";
            // 
            // frmDetaljiDokumentaIzlaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 378);
            this.Controls.Add(this.lblUkupnaCijena);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.lblPrikazPP);
            this.Controls.Add(this.lblPrikazZ);
            this.Controls.Add(this.lblArtikliDokumenta);
            this.Controls.Add(this.dgvStavkeDokumentaIzlaza);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblPoslovniPartner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetaljiDokumentaIzlaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji dokumenta izlaza";
            this.Load += new System.EventHandler(this.frmDetaljiDokumentaIzlaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumentaIzlaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrikazPP;
        private System.Windows.Forms.Label lblPrikazZ;
        private System.Windows.Forms.Label lblArtikliDokumenta;
        private System.Windows.Forms.DataGridView dgvStavkeDokumentaIzlaza;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblPoslovniPartner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblUkupnaCijena;
        private System.Windows.Forms.Label lblUkupno;
    }
}