namespace TBP
{
    partial class frmZaposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZaposlenici));
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPopisZaposlenika = new System.Windows.Forms.Label();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.btnIzmijeniZaposlenika = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.pbPomoc = new System.Windows.Forms.PictureBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.comboGrad = new System.Windows.Forms.ComboBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.dtpDatumZaposlenja = new System.Windows.Forms.DateTimePicker();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblDatumZaposlenja = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnObrisiZaposlenika = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10});
            this.dgvZaposlenici.Location = new System.Drawing.Point(40, 66);
            this.dgvZaposlenici.MultiSelect = false;
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(675, 213);
            this.dgvZaposlenici.TabIndex = 3;
            this.dgvZaposlenici.SelectionChanged += new System.EventHandler(this.dgvZaposlenici_SelectionChanged);
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column9.HeaderText = "Id";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "OIB";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Ime";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Prezime";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 57;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Kontakt";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.HeaderText = "Datum zaposlenja";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 106;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column7.HeaderText = "Adresa";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 65;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column8.HeaderText = "IdGrada";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column10.HeaderText = "Grad";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 55;
            // 
            // lblPopisZaposlenika
            // 
            this.lblPopisZaposlenika.AutoSize = true;
            this.lblPopisZaposlenika.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisZaposlenika.ForeColor = System.Drawing.Color.Black;
            this.lblPopisZaposlenika.Location = new System.Drawing.Point(36, 42);
            this.lblPopisZaposlenika.Name = "lblPopisZaposlenika";
            this.lblPopisZaposlenika.Size = new System.Drawing.Size(147, 21);
            this.lblPopisZaposlenika.TabIndex = 4;
            this.lblPopisZaposlenika.Text = "Popis zaposlenika:";
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.BackColor = System.Drawing.Color.LightGray;
            this.btnDodajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajZaposlenika.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajZaposlenika.ForeColor = System.Drawing.Color.Black;
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(40, 21);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(144, 35);
            this.btnDodajZaposlenika.TabIndex = 5;
            this.btnDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = false;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.prikazDodavanjaIzmjene);
            this.btnDodajZaposlenika.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnDodajZaposlenika.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnIzmijeniZaposlenika
            // 
            this.btnIzmijeniZaposlenika.BackColor = System.Drawing.Color.LightGray;
            this.btnIzmijeniZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmijeniZaposlenika.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmijeniZaposlenika.ForeColor = System.Drawing.Color.Black;
            this.btnIzmijeniZaposlenika.Location = new System.Drawing.Point(40, 62);
            this.btnIzmijeniZaposlenika.Name = "btnIzmijeniZaposlenika";
            this.btnIzmijeniZaposlenika.Size = new System.Drawing.Size(144, 35);
            this.btnIzmijeniZaposlenika.TabIndex = 6;
            this.btnIzmijeniZaposlenika.Text = "Izmijeni zaposlenika";
            this.btnIzmijeniZaposlenika.UseVisualStyleBackColor = false;
            this.btnIzmijeniZaposlenika.Click += new System.EventHandler(this.prikazDodavanjaIzmjene);
            this.btnIzmijeniZaposlenika.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnIzmijeniZaposlenika.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.btnObrisiZaposlenika);
            this.panel1.Controls.Add(this.btnIzmijeniZaposlenika);
            this.panel1.Controls.Add(this.btnDodajZaposlenika);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 186);
            this.panel1.TabIndex = 7;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtKontakt);
            this.panel.Controls.Add(this.pbPomoc);
            this.panel.Controls.Add(this.lblIme);
            this.panel.Controls.Add(this.comboGrad);
            this.panel.Controls.Add(this.lblPrezime);
            this.panel.Controls.Add(this.lblGrad);
            this.panel.Controls.Add(this.txtIme);
            this.panel.Controls.Add(this.dtpDatumZaposlenja);
            this.panel.Controls.Add(this.txtPrezime);
            this.panel.Controls.Add(this.lblDatumZaposlenja);
            this.panel.Controls.Add(this.lblOIB);
            this.panel.Controls.Add(this.txtAdresa);
            this.panel.Controls.Add(this.lblEmail);
            this.panel.Controls.Add(this.lblAdresa);
            this.panel.Controls.Add(this.lblKontakt);
            this.panel.Controls.Add(this.btnSpremi);
            this.panel.Controls.Add(this.txtOIB);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Location = new System.Drawing.Point(190, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(525, 181);
            this.panel.TabIndex = 8;
            this.panel.Visible = false;
            // 
            // txtKontakt
            // 
            this.txtKontakt.ForeColor = System.Drawing.Color.Black;
            this.txtKontakt.Location = new System.Drawing.Point(356, 16);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(131, 20);
            this.txtKontakt.TabIndex = 13;
            // 
            // pbPomoc
            // 
            this.pbPomoc.Image = ((System.Drawing.Image)(resources.GetObject("pbPomoc.Image")));
            this.pbPomoc.Location = new System.Drawing.Point(493, 46);
            this.pbPomoc.Name = "pbPomoc";
            this.pbPomoc.Size = new System.Drawing.Size(25, 21);
            this.pbPomoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPomoc.TabIndex = 30;
            this.pbPomoc.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPomoc, "Ukoliko ne postoji željeni grad, može se dodati klikom na gumb \"Lokacija\" u izbor" +
        "niku");
            this.pbPomoc.WaitOnLoad = true;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.Color.Black;
            this.lblIme.Location = new System.Drawing.Point(101, 50);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 17);
            this.lblIme.TabIndex = 8;
            this.lblIme.Text = "Ime";
            // 
            // comboGrad
            // 
            this.comboGrad.ForeColor = System.Drawing.Color.Black;
            this.comboGrad.FormattingEnabled = true;
            this.comboGrad.Location = new System.Drawing.Point(356, 46);
            this.comboGrad.Name = "comboGrad";
            this.comboGrad.Size = new System.Drawing.Size(131, 21);
            this.comboGrad.TabIndex = 14;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.ForeColor = System.Drawing.Color.Black;
            this.lblPrezime.Location = new System.Drawing.Point(75, 81);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(58, 17);
            this.lblPrezime.TabIndex = 9;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrad.ForeColor = System.Drawing.Color.Black;
            this.lblGrad.Location = new System.Drawing.Point(309, 48);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(41, 17);
            this.lblGrad.TabIndex = 24;
            this.lblGrad.Text = "Grad";
            // 
            // txtIme
            // 
            this.txtIme.ForeColor = System.Drawing.Color.Black;
            this.txtIme.Location = new System.Drawing.Point(139, 49);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(131, 20);
            this.txtIme.TabIndex = 9;
            // 
            // dtpDatumZaposlenja
            // 
            this.dtpDatumZaposlenja.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDatumZaposlenja.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpDatumZaposlenja.Location = new System.Drawing.Point(139, 150);
            this.dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            this.dtpDatumZaposlenja.Size = new System.Drawing.Size(131, 20);
            this.dtpDatumZaposlenja.TabIndex = 12;
            // 
            // txtPrezime
            // 
            this.txtPrezime.ForeColor = System.Drawing.Color.Black;
            this.txtPrezime.Location = new System.Drawing.Point(139, 80);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(131, 20);
            this.txtPrezime.TabIndex = 10;
            // 
            // lblDatumZaposlenja
            // 
            this.lblDatumZaposlenja.AutoSize = true;
            this.lblDatumZaposlenja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumZaposlenja.ForeColor = System.Drawing.Color.Black;
            this.lblDatumZaposlenja.Location = new System.Drawing.Point(7, 153);
            this.lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            this.lblDatumZaposlenja.Size = new System.Drawing.Size(126, 17);
            this.lblDatumZaposlenja.TabIndex = 22;
            this.lblDatumZaposlenja.Text = "Datum zaposlenja";
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOIB.ForeColor = System.Drawing.Color.Black;
            this.lblOIB.Location = new System.Drawing.Point(104, 19);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(29, 17);
            this.lblOIB.TabIndex = 13;
            this.lblOIB.Text = "OIB";
            // 
            // txtAdresa
            // 
            this.txtAdresa.ForeColor = System.Drawing.Color.Black;
            this.txtAdresa.Location = new System.Drawing.Point(356, 79);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(131, 20);
            this.txtAdresa.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(90, 114);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.Color.Black;
            this.lblAdresa.Location = new System.Drawing.Point(298, 80);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(52, 17);
            this.lblAdresa.TabIndex = 20;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontakt.ForeColor = System.Drawing.Color.Black;
            this.lblKontakt.Location = new System.Drawing.Point(291, 19);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(59, 17);
            this.lblKontakt.TabIndex = 15;
            this.lblKontakt.Text = "Kontakt";
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.LightGray;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.Color.Black;
            this.btnSpremi.Location = new System.Drawing.Point(356, 129);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(131, 41);
            this.btnSpremi.TabIndex = 16;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            this.btnSpremi.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnSpremi.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // txtOIB
            // 
            this.txtOIB.ForeColor = System.Drawing.Color.Black;
            this.txtOIB.Location = new System.Drawing.Point(139, 18);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(131, 20);
            this.txtOIB.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(139, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // btnObrisiZaposlenika
            // 
            this.btnObrisiZaposlenika.BackColor = System.Drawing.Color.LightGray;
            this.btnObrisiZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiZaposlenika.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiZaposlenika.ForeColor = System.Drawing.Color.Black;
            this.btnObrisiZaposlenika.Location = new System.Drawing.Point(39, 103);
            this.btnObrisiZaposlenika.Name = "btnObrisiZaposlenika";
            this.btnObrisiZaposlenika.Size = new System.Drawing.Size(144, 35);
            this.btnObrisiZaposlenika.TabIndex = 31;
            this.btnObrisiZaposlenika.Text = "Obriši zaposlenika";
            this.btnObrisiZaposlenika.UseVisualStyleBackColor = false;
            this.btnObrisiZaposlenika.Click += new System.EventHandler(this.btnObrisiZaposlenika_Click);
            this.btnObrisiZaposlenika.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnObrisiZaposlenika.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // frmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPopisZaposlenika);
            this.Controls.Add(this.dgvZaposlenici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmZaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmZaposlenici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Label lblPopisZaposlenika;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Button btnIzmijeniZaposlenika;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.ComboBox comboGrad;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.DateTimePicker dtpDatumZaposlenja;
        private System.Windows.Forms.Label lblDatumZaposlenja;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.PictureBox pbPomoc;
        private System.Windows.Forms.Button btnObrisiZaposlenika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel;
    }
}