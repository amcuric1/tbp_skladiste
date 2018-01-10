namespace TBP
{
    partial class frmPoslovniPartneri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoslovniPartneri));
            this.lblPopisPartnera = new System.Windows.Forms.Label();
            this.dgvPoslovniPartneri = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnObrisiPoslovnogPartnera = new System.Windows.Forms.Button();
            this.btnIzmijeniPoslovnogPartnera = new System.Windows.Forms.Button();
            this.btnDodajPoslovnogPartnera = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dtpPocetakPartnerstva = new System.Windows.Forms.DateTimePicker();
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblPocetakPartnerstva = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.pbPomoc = new System.Windows.Forms.PictureBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.comboGrad = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovniPartneri)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPopisPartnera
            // 
            this.lblPopisPartnera.AutoSize = true;
            this.lblPopisPartnera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisPartnera.ForeColor = System.Drawing.Color.Black;
            this.lblPopisPartnera.Location = new System.Drawing.Point(34, 41);
            this.lblPopisPartnera.Name = "lblPopisPartnera";
            this.lblPopisPartnera.Size = new System.Drawing.Size(204, 21);
            this.lblPopisPartnera.TabIndex = 5;
            this.lblPopisPartnera.Text = "Popis poslovnih partnera:";
            // 
            // dgvPoslovniPartneri
            // 
            this.dgvPoslovniPartneri.AllowUserToAddRows = false;
            this.dgvPoslovniPartneri.AllowUserToDeleteRows = false;
            this.dgvPoslovniPartneri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPoslovniPartneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslovniPartneri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvPoslovniPartneri.Location = new System.Drawing.Point(38, 65);
            this.dgvPoslovniPartneri.MultiSelect = false;
            this.dgvPoslovniPartneri.Name = "dgvPoslovniPartneri";
            this.dgvPoslovniPartneri.ReadOnly = true;
            this.dgvPoslovniPartneri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoslovniPartneri.Size = new System.Drawing.Size(676, 237);
            this.dgvPoslovniPartneri.TabIndex = 6;
            this.dgvPoslovniPartneri.SelectionChanged += new System.EventHandler(this.dgvPoslovniPartneri_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "OIB";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Naziv";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 59;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            this.Column6.HeaderText = "Datum početka partnerstva";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 99;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Adresa";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "IdGrada";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Naziv";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnObrisiPoslovnogPartnera);
            this.panel1.Controls.Add(this.btnIzmijeniPoslovnogPartnera);
            this.panel1.Controls.Add(this.btnDodajPoslovnogPartnera);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 170);
            this.panel1.TabIndex = 9;
            // 
            // btnObrisiPoslovnogPartnera
            // 
            this.btnObrisiPoslovnogPartnera.BackColor = System.Drawing.Color.LightGray;
            this.btnObrisiPoslovnogPartnera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiPoslovnogPartnera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiPoslovnogPartnera.ForeColor = System.Drawing.Color.Black;
            this.btnObrisiPoslovnogPartnera.Location = new System.Drawing.Point(38, 81);
            this.btnObrisiPoslovnogPartnera.Name = "btnObrisiPoslovnogPartnera";
            this.btnObrisiPoslovnogPartnera.Size = new System.Drawing.Size(200, 30);
            this.btnObrisiPoslovnogPartnera.TabIndex = 44;
            this.btnObrisiPoslovnogPartnera.Text = "Obriši poslovnog partnera";
            this.btnObrisiPoslovnogPartnera.UseVisualStyleBackColor = false;
            this.btnObrisiPoslovnogPartnera.Click += new System.EventHandler(this.btnObrisiPoslovnogPartnera_Click);
            this.btnObrisiPoslovnogPartnera.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnObrisiPoslovnogPartnera.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnIzmijeniPoslovnogPartnera
            // 
            this.btnIzmijeniPoslovnogPartnera.BackColor = System.Drawing.Color.LightGray;
            this.btnIzmijeniPoslovnogPartnera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmijeniPoslovnogPartnera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmijeniPoslovnogPartnera.ForeColor = System.Drawing.Color.Black;
            this.btnIzmijeniPoslovnogPartnera.Location = new System.Drawing.Point(38, 45);
            this.btnIzmijeniPoslovnogPartnera.Name = "btnIzmijeniPoslovnogPartnera";
            this.btnIzmijeniPoslovnogPartnera.Size = new System.Drawing.Size(200, 30);
            this.btnIzmijeniPoslovnogPartnera.TabIndex = 43;
            this.btnIzmijeniPoslovnogPartnera.Text = "Izmijeni poslovnog partnera";
            this.btnIzmijeniPoslovnogPartnera.UseVisualStyleBackColor = false;
            this.btnIzmijeniPoslovnogPartnera.Click += new System.EventHandler(this.prikaz);
            this.btnIzmijeniPoslovnogPartnera.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnIzmijeniPoslovnogPartnera.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnDodajPoslovnogPartnera
            // 
            this.btnDodajPoslovnogPartnera.BackColor = System.Drawing.Color.LightGray;
            this.btnDodajPoslovnogPartnera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajPoslovnogPartnera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPoslovnogPartnera.ForeColor = System.Drawing.Color.Black;
            this.btnDodajPoslovnogPartnera.Location = new System.Drawing.Point(38, 8);
            this.btnDodajPoslovnogPartnera.Name = "btnDodajPoslovnogPartnera";
            this.btnDodajPoslovnogPartnera.Size = new System.Drawing.Size(200, 30);
            this.btnDodajPoslovnogPartnera.TabIndex = 42;
            this.btnDodajPoslovnogPartnera.Text = "Dodaj poslovnog partnera";
            this.btnDodajPoslovnogPartnera.UseVisualStyleBackColor = false;
            this.btnDodajPoslovnogPartnera.Click += new System.EventHandler(this.prikaz);
            this.btnDodajPoslovnogPartnera.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnDodajPoslovnogPartnera.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnSpremi);
            this.panel.Controls.Add(this.dtpPocetakPartnerstva);
            this.panel.Controls.Add(this.lblOIB);
            this.panel.Controls.Add(this.lblPocetakPartnerstva);
            this.panel.Controls.Add(this.txtOIB);
            this.panel.Controls.Add(this.pbPomoc);
            this.panel.Controls.Add(this.lblNaziv);
            this.panel.Controls.Add(this.comboGrad);
            this.panel.Controls.Add(this.txtNaziv);
            this.panel.Controls.Add(this.lblGrad);
            this.panel.Controls.Add(this.lblEmail);
            this.panel.Controls.Add(this.txtKontakt);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Controls.Add(this.lblKontakt);
            this.panel.Controls.Add(this.lblAdresa);
            this.panel.Controls.Add(this.txtAdresa);
            this.panel.Location = new System.Drawing.Point(192, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(539, 167);
            this.panel.TabIndex = 41;
            this.panel.Visible = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.BackColor = System.Drawing.Color.LightGray;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.Color.Black;
            this.btnSpremi.Location = new System.Drawing.Point(362, 123);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(132, 35);
            this.btnSpremi.TabIndex = 25;
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            this.btnSpremi.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnSpremi.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // dtpPocetakPartnerstva
            // 
            this.dtpPocetakPartnerstva.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpPocetakPartnerstva.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpPocetakPartnerstva.Location = new System.Drawing.Point(160, 123);
            this.dtpPocetakPartnerstva.Name = "dtpPocetakPartnerstva";
            this.dtpPocetakPartnerstva.Size = new System.Drawing.Size(131, 20);
            this.dtpPocetakPartnerstva.TabIndex = 21;
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOIB.ForeColor = System.Drawing.Color.Black;
            this.lblOIB.Location = new System.Drawing.Point(125, 23);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(29, 17);
            this.lblOIB.TabIndex = 17;
            this.lblOIB.Text = "OIB";
            // 
            // lblPocetakPartnerstva
            // 
            this.lblPocetakPartnerstva.AutoSize = true;
            this.lblPocetakPartnerstva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPocetakPartnerstva.ForeColor = System.Drawing.Color.Black;
            this.lblPocetakPartnerstva.Location = new System.Drawing.Point(14, 123);
            this.lblPocetakPartnerstva.Name = "lblPocetakPartnerstva";
            this.lblPocetakPartnerstva.Size = new System.Drawing.Size(140, 17);
            this.lblPocetakPartnerstva.TabIndex = 38;
            this.lblPocetakPartnerstva.Text = "Početak partnerstva";
            // 
            // txtOIB
            // 
            this.txtOIB.ForeColor = System.Drawing.Color.Black;
            this.txtOIB.Location = new System.Drawing.Point(160, 22);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(131, 20);
            this.txtOIB.TabIndex = 18;
            // 
            // pbPomoc
            // 
            this.pbPomoc.Image = ((System.Drawing.Image)(resources.GetObject("pbPomoc.Image")));
            this.pbPomoc.Location = new System.Drawing.Point(502, 84);
            this.pbPomoc.Name = "pbPomoc";
            this.pbPomoc.Size = new System.Drawing.Size(25, 21);
            this.pbPomoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPomoc.TabIndex = 31;
            this.pbPomoc.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPomoc, "Ukoliko ne postoji željeni grad, može se dodati klikom na gumb \"Lokacija\" u izbor" +
        "niku");
            this.pbPomoc.WaitOnLoad = true;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.Black;
            this.lblNaziv.Location = new System.Drawing.Point(110, 56);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 17);
            this.lblNaziv.TabIndex = 19;
            this.lblNaziv.Text = "Naziv";
            // 
            // comboGrad
            // 
            this.comboGrad.ForeColor = System.Drawing.Color.Black;
            this.comboGrad.FormattingEnabled = true;
            this.comboGrad.Location = new System.Drawing.Point(362, 84);
            this.comboGrad.Name = "comboGrad";
            this.comboGrad.Size = new System.Drawing.Size(132, 21);
            this.comboGrad.TabIndex = 24;
            // 
            // txtNaziv
            // 
            this.txtNaziv.ForeColor = System.Drawing.Color.Black;
            this.txtNaziv.Location = new System.Drawing.Point(160, 55);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(131, 20);
            this.txtNaziv.TabIndex = 19;
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrad.ForeColor = System.Drawing.Color.Black;
            this.lblGrad.Location = new System.Drawing.Point(315, 88);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(41, 17);
            this.lblGrad.TabIndex = 36;
            this.lblGrad.Text = "Grad";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(111, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email";
            // 
            // txtKontakt
            // 
            this.txtKontakt.ForeColor = System.Drawing.Color.Black;
            this.txtKontakt.Location = new System.Drawing.Point(362, 20);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(132, 20);
            this.txtKontakt.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(160, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontakt.ForeColor = System.Drawing.Color.Black;
            this.lblKontakt.Location = new System.Drawing.Point(297, 22);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(59, 17);
            this.lblKontakt.TabIndex = 30;
            this.lblKontakt.Text = "Kontakt";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.Color.Black;
            this.lblAdresa.Location = new System.Drawing.Point(304, 53);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(52, 17);
            this.lblAdresa.TabIndex = 34;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.ForeColor = System.Drawing.Color.Black;
            this.txtAdresa.Location = new System.Drawing.Point(362, 53);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(132, 20);
            this.txtAdresa.TabIndex = 23;
            // 
            // frmPoslovniPartneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPoslovniPartneri);
            this.Controls.Add(this.lblPopisPartnera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPoslovniPartneri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPoslovniPartneri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPoslovniPartneri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovniPartneri)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPopisPartnera;
        private System.Windows.Forms.DataGridView dgvPoslovniPartneri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.ComboBox comboGrad;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pbPomoc;
        private System.Windows.Forms.DateTimePicker dtpPocetakPartnerstva;
        private System.Windows.Forms.Label lblPocetakPartnerstva;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnObrisiPoslovnogPartnera;
        private System.Windows.Forms.Button btnIzmijeniPoslovnogPartnera;
        private System.Windows.Forms.Button btnDodajPoslovnogPartnera;
        private System.Windows.Forms.Panel panel;
    }
}