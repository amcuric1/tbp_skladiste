namespace TBP
{
    partial class frmArtikli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtikli));
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPopisArtikala = new System.Windows.Forms.Label();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.btnIzmijeniArtikl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.pbPomoc = new System.Windows.Forms.PictureBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblJedinicnaCijena = new System.Windows.Forms.Label();
            this.comboJedinicaMjere = new System.Windows.Forms.ComboBox();
            this.txtJedinicnaCijena = new System.Windows.Forms.TextBox();
            this.lblJedinicaMjere = new System.Windows.Forms.Label();
            this.lblKolicinaNaSkladistu = new System.Windows.Forms.Label();
            this.txtMinimalnaKoličina = new System.Windows.Forms.TextBox();
            this.txtKolicinaNaSkladistu = new System.Windows.Forms.TextBox();
            this.lblMiminalnaKoličina = new System.Windows.Forms.Label();
            this.btnObrisiArtikl = new System.Windows.Forms.Button();
            this.btnJedinicaMjere = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvArtikli.Location = new System.Drawing.Point(38, 66);
            this.dgvArtikli.MultiSelect = false;
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.ReadOnly = true;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(679, 201);
            this.dgvArtikli.TabIndex = 0;
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
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Naziv";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Jedinicna cijena";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 99;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Količina na skladištu";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "Minimalna količina na skladištu";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 111;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IdJediniceMjere";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Mjera";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // lblPopisArtikala
            // 
            this.lblPopisArtikala.AutoSize = true;
            this.lblPopisArtikala.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisArtikala.ForeColor = System.Drawing.Color.Black;
            this.lblPopisArtikala.Location = new System.Drawing.Point(34, 42);
            this.lblPopisArtikala.Name = "lblPopisArtikala";
            this.lblPopisArtikala.Size = new System.Drawing.Size(116, 21);
            this.lblPopisArtikala.TabIndex = 1;
            this.lblPopisArtikala.Text = "Popis artikala:";
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.BackColor = System.Drawing.Color.LightGray;
            this.btnDodajArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajArtikl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnDodajArtikl.Location = new System.Drawing.Point(36, 90);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(144, 35);
            this.btnDodajArtikl.TabIndex = 1;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = false;
            this.btnDodajArtikl.Click += new System.EventHandler(this.prikaz);
            this.btnDodajArtikl.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnDodajArtikl.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnIzmijeniArtikl
            // 
            this.btnIzmijeniArtikl.BackColor = System.Drawing.Color.LightGray;
            this.btnIzmijeniArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmijeniArtikl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmijeniArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnIzmijeniArtikl.Location = new System.Drawing.Point(36, 131);
            this.btnIzmijeniArtikl.Name = "btnIzmijeniArtikl";
            this.btnIzmijeniArtikl.Size = new System.Drawing.Size(144, 35);
            this.btnIzmijeniArtikl.TabIndex = 2;
            this.btnIzmijeniArtikl.Text = "Izmijeni artikl";
            this.btnIzmijeniArtikl.UseVisualStyleBackColor = false;
            this.btnIzmijeniArtikl.Click += new System.EventHandler(this.prikaz);
            this.btnIzmijeniArtikl.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnIzmijeniArtikl.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.btnObrisiArtikl);
            this.panel1.Controls.Add(this.btnJedinicaMjere);
            this.panel1.Controls.Add(this.btnDodajArtikl);
            this.panel1.Controls.Add(this.btnIzmijeniArtikl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 219);
            this.panel1.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pbPomoc);
            this.panel.Controls.Add(this.txtNaziv);
            this.panel.Controls.Add(this.lblNaziv);
            this.panel.Controls.Add(this.btnSpremi);
            this.panel.Controls.Add(this.lblJedinicnaCijena);
            this.panel.Controls.Add(this.comboJedinicaMjere);
            this.panel.Controls.Add(this.txtJedinicnaCijena);
            this.panel.Controls.Add(this.lblJedinicaMjere);
            this.panel.Controls.Add(this.lblKolicinaNaSkladistu);
            this.panel.Controls.Add(this.txtMinimalnaKoličina);
            this.panel.Controls.Add(this.txtKolicinaNaSkladistu);
            this.panel.Controls.Add(this.lblMiminalnaKoličina);
            this.panel.Location = new System.Drawing.Point(248, 14);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(469, 193);
            this.panel.TabIndex = 5;
            this.panel.Visible = false;
            // 
            // pbPomoc
            // 
            this.pbPomoc.Image = ((System.Drawing.Image)(resources.GetObject("pbPomoc.Image")));
            this.pbPomoc.Location = new System.Drawing.Point(338, 151);
            this.pbPomoc.Name = "pbPomoc";
            this.pbPomoc.Size = new System.Drawing.Size(25, 21);
            this.pbPomoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPomoc.TabIndex = 29;
            this.pbPomoc.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPomoc, "Ukoliko ne postoji željena jedinca mjere, potrebno ju je dodati klikom na gumb \"J" +
        "edinica mjere artikala\"");
            this.pbPomoc.WaitOnLoad = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNaziv.ForeColor = System.Drawing.Color.Black;
            this.txtNaziv.Location = new System.Drawing.Point(201, 17);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(131, 20);
            this.txtNaziv.TabIndex = 18;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.Black;
            this.lblNaziv.Location = new System.Drawing.Point(151, 18);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 17);
            this.lblNaziv.TabIndex = 17;
            this.lblNaziv.Text = "Naziv";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpremi.BackColor = System.Drawing.Color.LightGray;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.Color.Black;
            this.btnSpremi.Location = new System.Drawing.Point(362, 76);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(89, 36);
            this.btnSpremi.TabIndex = 20;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblJedinicnaCijena
            // 
            this.lblJedinicnaCijena.AutoSize = true;
            this.lblJedinicnaCijena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJedinicnaCijena.ForeColor = System.Drawing.Color.Black;
            this.lblJedinicnaCijena.Location = new System.Drawing.Point(82, 51);
            this.lblJedinicnaCijena.Name = "lblJedinicnaCijena";
            this.lblJedinicnaCijena.Size = new System.Drawing.Size(113, 17);
            this.lblJedinicnaCijena.TabIndex = 19;
            this.lblJedinicnaCijena.Text = "Jedinična cijena";
            // 
            // comboJedinicaMjere
            // 
            this.comboJedinicaMjere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboJedinicaMjere.ForeColor = System.Drawing.Color.Black;
            this.comboJedinicaMjere.FormattingEnabled = true;
            this.comboJedinicaMjere.Location = new System.Drawing.Point(201, 151);
            this.comboJedinicaMjere.Name = "comboJedinicaMjere";
            this.comboJedinicaMjere.Size = new System.Drawing.Size(131, 21);
            this.comboJedinicaMjere.TabIndex = 26;
            // 
            // txtJedinicnaCijena
            // 
            this.txtJedinicnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtJedinicnaCijena.ForeColor = System.Drawing.Color.Black;
            this.txtJedinicnaCijena.Location = new System.Drawing.Point(201, 50);
            this.txtJedinicnaCijena.Name = "txtJedinicnaCijena";
            this.txtJedinicnaCijena.Size = new System.Drawing.Size(131, 20);
            this.txtJedinicnaCijena.TabIndex = 20;
            // 
            // lblJedinicaMjere
            // 
            this.lblJedinicaMjere.AutoSize = true;
            this.lblJedinicaMjere.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJedinicaMjere.ForeColor = System.Drawing.Color.Black;
            this.lblJedinicaMjere.Location = new System.Drawing.Point(93, 151);
            this.lblJedinicaMjere.Name = "lblJedinicaMjere";
            this.lblJedinicaMjere.Size = new System.Drawing.Size(102, 17);
            this.lblJedinicaMjere.TabIndex = 25;
            this.lblJedinicaMjere.Text = "Jedinica mjere";
            // 
            // lblKolicinaNaSkladistu
            // 
            this.lblKolicinaNaSkladistu.AutoSize = true;
            this.lblKolicinaNaSkladistu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicinaNaSkladistu.ForeColor = System.Drawing.Color.Black;
            this.lblKolicinaNaSkladistu.Location = new System.Drawing.Point(57, 86);
            this.lblKolicinaNaSkladistu.Name = "lblKolicinaNaSkladistu";
            this.lblKolicinaNaSkladistu.Size = new System.Drawing.Size(138, 17);
            this.lblKolicinaNaSkladistu.TabIndex = 21;
            this.lblKolicinaNaSkladistu.Text = "Količina na skladištu";
            // 
            // txtMinimalnaKoličina
            // 
            this.txtMinimalnaKoličina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMinimalnaKoličina.ForeColor = System.Drawing.Color.Black;
            this.txtMinimalnaKoličina.Location = new System.Drawing.Point(201, 116);
            this.txtMinimalnaKoličina.Name = "txtMinimalnaKoličina";
            this.txtMinimalnaKoličina.Size = new System.Drawing.Size(68, 20);
            this.txtMinimalnaKoličina.TabIndex = 24;
            // 
            // txtKolicinaNaSkladistu
            // 
            this.txtKolicinaNaSkladistu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtKolicinaNaSkladistu.ForeColor = System.Drawing.Color.Black;
            this.txtKolicinaNaSkladistu.Location = new System.Drawing.Point(201, 85);
            this.txtKolicinaNaSkladistu.Name = "txtKolicinaNaSkladistu";
            this.txtKolicinaNaSkladistu.Size = new System.Drawing.Size(68, 20);
            this.txtKolicinaNaSkladistu.TabIndex = 22;
            // 
            // lblMiminalnaKoličina
            // 
            this.lblMiminalnaKoličina.AutoSize = true;
            this.lblMiminalnaKoličina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiminalnaKoličina.ForeColor = System.Drawing.Color.Black;
            this.lblMiminalnaKoličina.Location = new System.Drawing.Point(28, 117);
            this.lblMiminalnaKoličina.Name = "lblMiminalnaKoličina";
            this.lblMiminalnaKoličina.Size = new System.Drawing.Size(167, 17);
            this.lblMiminalnaKoličina.TabIndex = 23;
            this.lblMiminalnaKoličina.Text = "Min. količina na skladištu";
            // 
            // btnObrisiArtikl
            // 
            this.btnObrisiArtikl.BackColor = System.Drawing.Color.LightGray;
            this.btnObrisiArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiArtikl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnObrisiArtikl.Location = new System.Drawing.Point(36, 172);
            this.btnObrisiArtikl.Name = "btnObrisiArtikl";
            this.btnObrisiArtikl.Size = new System.Drawing.Size(144, 35);
            this.btnObrisiArtikl.TabIndex = 29;
            this.btnObrisiArtikl.Text = "Obriši artikl";
            this.btnObrisiArtikl.UseVisualStyleBackColor = false;
            this.btnObrisiArtikl.Click += new System.EventHandler(this.btnObrisiArtikl_Click);
            this.btnObrisiArtikl.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnObrisiArtikl.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnJedinicaMjere
            // 
            this.btnJedinicaMjere.BackColor = System.Drawing.Color.LightGray;
            this.btnJedinicaMjere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJedinicaMjere.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJedinicaMjere.ForeColor = System.Drawing.Color.Black;
            this.btnJedinicaMjere.Location = new System.Drawing.Point(36, 3);
            this.btnJedinicaMjere.Name = "btnJedinicaMjere";
            this.btnJedinicaMjere.Size = new System.Drawing.Size(144, 54);
            this.btnJedinicaMjere.TabIndex = 28;
            this.btnJedinicaMjere.Text = "Jedinica mjere artikala";
            this.btnJedinicaMjere.UseVisualStyleBackColor = false;
            this.btnJedinicaMjere.Click += new System.EventHandler(this.btnJedinicaMjere_Click);
            this.btnJedinicaMjere.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnJedinicaMjere.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // frmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPopisArtikala);
            this.Controls.Add(this.dgvArtikli);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArtikli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmArtikli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Label lblPopisArtikala;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.Button btnIzmijeniArtikl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJedinicaMjere;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnObrisiArtikl;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pbPomoc;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblJedinicnaCijena;
        private System.Windows.Forms.ComboBox comboJedinicaMjere;
        private System.Windows.Forms.TextBox txtJedinicnaCijena;
        private System.Windows.Forms.Label lblJedinicaMjere;
        private System.Windows.Forms.Label lblKolicinaNaSkladistu;
        private System.Windows.Forms.TextBox txtMinimalnaKoličina;
        private System.Windows.Forms.TextBox txtKolicinaNaSkladistu;
        private System.Windows.Forms.Label lblMiminalnaKoličina;
    }
}