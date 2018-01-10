namespace TBP
{
    partial class frmGradDrzava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGradDrzava));
            this.lblPopisDrzava = new System.Windows.Forms.Label();
            this.lblPopisGradova = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDrzave = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGradovi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajDrzavu = new System.Windows.Forms.Button();
            this.btnIzmijeniDrzavu = new System.Windows.Forms.Button();
            this.btnObrisiDrzavu = new System.Windows.Forms.Button();
            this.btnObrisiGrad = new System.Windows.Forms.Button();
            this.btnIzmijeniGrad = new System.Windows.Forms.Button();
            this.btnDodajGrad = new System.Windows.Forms.Button();
            this.txtNazivDrzave = new System.Windows.Forms.TextBox();
            this.lblNazivDrzave = new System.Windows.Forms.Label();
            this.txtNazivGrada = new System.Windows.Forms.TextBox();
            this.lblNazivGrada = new System.Windows.Forms.Label();
            this.lblDrzava = new System.Windows.Forms.Label();
            this.comboDrzava = new System.Windows.Forms.ComboBox();
            this.btnSpremiDrzavu = new System.Windows.Forms.Button();
            this.btnSpremiGrad = new System.Windows.Forms.Button();
            this.pbPomoc = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrzave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPopisDrzava
            // 
            this.lblPopisDrzava.AutoSize = true;
            this.lblPopisDrzava.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisDrzava.ForeColor = System.Drawing.Color.Black;
            this.lblPopisDrzava.Location = new System.Drawing.Point(21, 40);
            this.lblPopisDrzava.Name = "lblPopisDrzava";
            this.lblPopisDrzava.Size = new System.Drawing.Size(112, 21);
            this.lblPopisDrzava.TabIndex = 2;
            this.lblPopisDrzava.Text = "Popis država:";
            // 
            // lblPopisGradova
            // 
            this.lblPopisGradova.AutoSize = true;
            this.lblPopisGradova.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisGradova.ForeColor = System.Drawing.Color.Black;
            this.lblPopisGradova.Location = new System.Drawing.Point(408, 40);
            this.lblPopisGradova.Name = "lblPopisGradova";
            this.lblPopisGradova.Size = new System.Drawing.Size(126, 21);
            this.lblPopisGradova.TabIndex = 3;
            this.lblPopisGradova.Text = "Popis gradova:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(366, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 504);
            this.panel1.TabIndex = 4;
            // 
            // dgvDrzave
            // 
            this.dgvDrzave.AllowUserToAddRows = false;
            this.dgvDrzave.AllowUserToDeleteRows = false;
            this.dgvDrzave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrzave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv});
            this.dgvDrzave.Location = new System.Drawing.Point(25, 64);
            this.dgvDrzave.MultiSelect = false;
            this.dgvDrzave.Name = "dgvDrzave";
            this.dgvDrzave.ReadOnly = true;
            this.dgvDrzave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrzave.Size = new System.Drawing.Size(309, 177);
            this.dgvDrzave.TabIndex = 5;
            this.dgvDrzave.SelectionChanged += new System.EventHandler(this.dgvDrzave_SelectionChanged);
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
            // dgvGradovi
            // 
            this.dgvGradovi.AllowUserToAddRows = false;
            this.dgvGradovi.AllowUserToDeleteRows = false;
            this.dgvGradovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvGradovi.Location = new System.Drawing.Point(412, 64);
            this.dgvGradovi.MultiSelect = false;
            this.dgvGradovi.Name = "dgvGradovi";
            this.dgvGradovi.ReadOnly = true;
            this.dgvGradovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradovi.Size = new System.Drawing.Size(309, 177);
            this.dgvGradovi.TabIndex = 6;
            this.dgvGradovi.SelectionChanged += new System.EventHandler(this.dgvGradovi_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdGrada";
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
            this.Column3.HeaderText = "IdDrzave";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Država";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnDodajDrzavu
            // 
            this.btnDodajDrzavu.BackColor = System.Drawing.Color.LightGray;
            this.btnDodajDrzavu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajDrzavu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajDrzavu.ForeColor = System.Drawing.Color.Black;
            this.btnDodajDrzavu.Location = new System.Drawing.Point(25, 247);
            this.btnDodajDrzavu.Name = "btnDodajDrzavu";
            this.btnDodajDrzavu.Size = new System.Drawing.Size(144, 35);
            this.btnDodajDrzavu.TabIndex = 7;
            this.btnDodajDrzavu.Text = "Dodaj državu";
            this.btnDodajDrzavu.UseVisualStyleBackColor = false;
            this.btnDodajDrzavu.Click += new System.EventHandler(this.prikazDrzave);
            this.btnDodajDrzavu.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnDodajDrzavu.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnIzmijeniDrzavu
            // 
            this.btnIzmijeniDrzavu.BackColor = System.Drawing.Color.LightGray;
            this.btnIzmijeniDrzavu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmijeniDrzavu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmijeniDrzavu.ForeColor = System.Drawing.Color.Black;
            this.btnIzmijeniDrzavu.Location = new System.Drawing.Point(190, 247);
            this.btnIzmijeniDrzavu.Name = "btnIzmijeniDrzavu";
            this.btnIzmijeniDrzavu.Size = new System.Drawing.Size(144, 35);
            this.btnIzmijeniDrzavu.TabIndex = 8;
            this.btnIzmijeniDrzavu.Text = "Izmijeni državu";
            this.btnIzmijeniDrzavu.UseVisualStyleBackColor = false;
            this.btnIzmijeniDrzavu.Click += new System.EventHandler(this.prikazDrzave);
            this.btnIzmijeniDrzavu.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnIzmijeniDrzavu.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnObrisiDrzavu
            // 
            this.btnObrisiDrzavu.BackColor = System.Drawing.Color.LightGray;
            this.btnObrisiDrzavu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiDrzavu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiDrzavu.ForeColor = System.Drawing.Color.Black;
            this.btnObrisiDrzavu.Location = new System.Drawing.Point(107, 288);
            this.btnObrisiDrzavu.Name = "btnObrisiDrzavu";
            this.btnObrisiDrzavu.Size = new System.Drawing.Size(144, 35);
            this.btnObrisiDrzavu.TabIndex = 9;
            this.btnObrisiDrzavu.Text = "Obriši državu";
            this.btnObrisiDrzavu.UseVisualStyleBackColor = false;
            this.btnObrisiDrzavu.Click += new System.EventHandler(this.btnObrisiDrzavu_Click);
            this.btnObrisiDrzavu.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnObrisiDrzavu.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnObrisiGrad
            // 
            this.btnObrisiGrad.BackColor = System.Drawing.Color.LightGray;
            this.btnObrisiGrad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiGrad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiGrad.ForeColor = System.Drawing.Color.Black;
            this.btnObrisiGrad.Location = new System.Drawing.Point(493, 288);
            this.btnObrisiGrad.Name = "btnObrisiGrad";
            this.btnObrisiGrad.Size = new System.Drawing.Size(144, 35);
            this.btnObrisiGrad.TabIndex = 12;
            this.btnObrisiGrad.Text = "Obriši grad";
            this.btnObrisiGrad.UseVisualStyleBackColor = false;
            this.btnObrisiGrad.Click += new System.EventHandler(this.btnObrisiGrad_Click);
            this.btnObrisiGrad.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnObrisiGrad.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnIzmijeniGrad
            // 
            this.btnIzmijeniGrad.BackColor = System.Drawing.Color.LightGray;
            this.btnIzmijeniGrad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmijeniGrad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmijeniGrad.ForeColor = System.Drawing.Color.Black;
            this.btnIzmijeniGrad.Location = new System.Drawing.Point(576, 247);
            this.btnIzmijeniGrad.Name = "btnIzmijeniGrad";
            this.btnIzmijeniGrad.Size = new System.Drawing.Size(144, 35);
            this.btnIzmijeniGrad.TabIndex = 11;
            this.btnIzmijeniGrad.Text = "Izmijeni grad";
            this.btnIzmijeniGrad.UseVisualStyleBackColor = false;
            this.btnIzmijeniGrad.Click += new System.EventHandler(this.prikazGrada);
            this.btnIzmijeniGrad.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnIzmijeniGrad.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnDodajGrad
            // 
            this.btnDodajGrad.BackColor = System.Drawing.Color.LightGray;
            this.btnDodajGrad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajGrad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajGrad.ForeColor = System.Drawing.Color.Black;
            this.btnDodajGrad.Location = new System.Drawing.Point(411, 247);
            this.btnDodajGrad.Name = "btnDodajGrad";
            this.btnDodajGrad.Size = new System.Drawing.Size(144, 35);
            this.btnDodajGrad.TabIndex = 10;
            this.btnDodajGrad.Text = "Dodaj grad";
            this.btnDodajGrad.UseVisualStyleBackColor = false;
            this.btnDodajGrad.Click += new System.EventHandler(this.prikazGrada);
            this.btnDodajGrad.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnDodajGrad.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // txtNazivDrzave
            // 
            this.txtNazivDrzave.ForeColor = System.Drawing.Color.Black;
            this.txtNazivDrzave.Location = new System.Drawing.Point(120, 407);
            this.txtNazivDrzave.Name = "txtNazivDrzave";
            this.txtNazivDrzave.Size = new System.Drawing.Size(131, 20);
            this.txtNazivDrzave.TabIndex = 20;
            this.txtNazivDrzave.Visible = false;
            // 
            // lblNazivDrzave
            // 
            this.lblNazivDrzave.AutoSize = true;
            this.lblNazivDrzave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivDrzave.ForeColor = System.Drawing.Color.Black;
            this.lblNazivDrzave.Location = new System.Drawing.Point(70, 408);
            this.lblNazivDrzave.Name = "lblNazivDrzave";
            this.lblNazivDrzave.Size = new System.Drawing.Size(44, 17);
            this.lblNazivDrzave.TabIndex = 19;
            this.lblNazivDrzave.Text = "Naziv";
            this.lblNazivDrzave.Visible = false;
            // 
            // txtNazivGrada
            // 
            this.txtNazivGrada.ForeColor = System.Drawing.Color.Black;
            this.txtNazivGrada.Location = new System.Drawing.Point(506, 385);
            this.txtNazivGrada.Name = "txtNazivGrada";
            this.txtNazivGrada.Size = new System.Drawing.Size(131, 20);
            this.txtNazivGrada.TabIndex = 22;
            this.txtNazivGrada.Visible = false;
            // 
            // lblNazivGrada
            // 
            this.lblNazivGrada.AutoSize = true;
            this.lblNazivGrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivGrada.ForeColor = System.Drawing.Color.Black;
            this.lblNazivGrada.Location = new System.Drawing.Point(456, 386);
            this.lblNazivGrada.Name = "lblNazivGrada";
            this.lblNazivGrada.Size = new System.Drawing.Size(44, 17);
            this.lblNazivGrada.TabIndex = 21;
            this.lblNazivGrada.Text = "Naziv";
            this.lblNazivGrada.Visible = false;
            // 
            // lblDrzava
            // 
            this.lblDrzava.AutoSize = true;
            this.lblDrzava.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrzava.ForeColor = System.Drawing.Color.Black;
            this.lblDrzava.Location = new System.Drawing.Point(446, 412);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(54, 17);
            this.lblDrzava.TabIndex = 23;
            this.lblDrzava.Text = "Država";
            this.lblDrzava.Visible = false;
            // 
            // comboDrzava
            // 
            this.comboDrzava.ForeColor = System.Drawing.Color.Black;
            this.comboDrzava.FormattingEnabled = true;
            this.comboDrzava.Location = new System.Drawing.Point(506, 411);
            this.comboDrzava.Name = "comboDrzava";
            this.comboDrzava.Size = new System.Drawing.Size(131, 21);
            this.comboDrzava.TabIndex = 24;
            this.comboDrzava.Visible = false;
            // 
            // btnSpremiDrzavu
            // 
            this.btnSpremiDrzavu.BackColor = System.Drawing.Color.LightGray;
            this.btnSpremiDrzavu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremiDrzavu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiDrzavu.ForeColor = System.Drawing.Color.Black;
            this.btnSpremiDrzavu.Location = new System.Drawing.Point(120, 446);
            this.btnSpremiDrzavu.Name = "btnSpremiDrzavu";
            this.btnSpremiDrzavu.Size = new System.Drawing.Size(131, 30);
            this.btnSpremiDrzavu.TabIndex = 25;
            this.btnSpremiDrzavu.UseVisualStyleBackColor = false;
            this.btnSpremiDrzavu.Visible = false;
            this.btnSpremiDrzavu.Click += new System.EventHandler(this.btnSpremiDrzavu_Click);
            this.btnSpremiDrzavu.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnSpremiDrzavu.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnSpremiGrad
            // 
            this.btnSpremiGrad.BackColor = System.Drawing.Color.LightGray;
            this.btnSpremiGrad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremiGrad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiGrad.ForeColor = System.Drawing.Color.Black;
            this.btnSpremiGrad.Location = new System.Drawing.Point(506, 446);
            this.btnSpremiGrad.Name = "btnSpremiGrad";
            this.btnSpremiGrad.Size = new System.Drawing.Size(131, 30);
            this.btnSpremiGrad.TabIndex = 26;
            this.btnSpremiGrad.UseVisualStyleBackColor = false;
            this.btnSpremiGrad.Visible = false;
            this.btnSpremiGrad.Click += new System.EventHandler(this.btnSpremiGrad_Click);
            this.btnSpremiGrad.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnSpremiGrad.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // pbPomoc
            // 
            this.pbPomoc.Image = ((System.Drawing.Image)(resources.GetObject("pbPomoc.Image")));
            this.pbPomoc.Location = new System.Drawing.Point(643, 411);
            this.pbPomoc.Name = "pbPomoc";
            this.pbPomoc.Size = new System.Drawing.Size(25, 21);
            this.pbPomoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPomoc.TabIndex = 30;
            this.pbPomoc.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPomoc, "Ukoliko ne postoji željena država, može se dodati klikom na gumb \"Dodaj državu\"");
            this.pbPomoc.Visible = false;
            this.pbPomoc.WaitOnLoad = true;
            // 
            // frmGradDrzava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 504);
            this.Controls.Add(this.pbPomoc);
            this.Controls.Add(this.btnSpremiGrad);
            this.Controls.Add(this.btnSpremiDrzavu);
            this.Controls.Add(this.comboDrzava);
            this.Controls.Add(this.lblDrzava);
            this.Controls.Add(this.txtNazivGrada);
            this.Controls.Add(this.lblNazivGrada);
            this.Controls.Add(this.txtNazivDrzave);
            this.Controls.Add(this.lblNazivDrzave);
            this.Controls.Add(this.btnObrisiGrad);
            this.Controls.Add(this.btnIzmijeniGrad);
            this.Controls.Add(this.btnDodajGrad);
            this.Controls.Add(this.btnObrisiDrzavu);
            this.Controls.Add(this.btnIzmijeniDrzavu);
            this.Controls.Add(this.btnDodajDrzavu);
            this.Controls.Add(this.dgvGradovi);
            this.Controls.Add(this.dgvDrzave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPopisGradova);
            this.Controls.Add(this.lblPopisDrzava);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGradDrzava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmGradDrzava";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGradDrzava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrzave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPomoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPopisDrzava;
        private System.Windows.Forms.Label lblPopisGradova;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDrzave;
        private System.Windows.Forms.DataGridView dgvGradovi;
        private System.Windows.Forms.Button btnDodajDrzavu;
        private System.Windows.Forms.Button btnIzmijeniDrzavu;
        private System.Windows.Forms.Button btnObrisiDrzavu;
        private System.Windows.Forms.Button btnObrisiGrad;
        private System.Windows.Forms.Button btnIzmijeniGrad;
        private System.Windows.Forms.Button btnDodajGrad;
        private System.Windows.Forms.TextBox txtNazivDrzave;
        private System.Windows.Forms.Label lblNazivDrzave;
        private System.Windows.Forms.TextBox txtNazivGrada;
        private System.Windows.Forms.Label lblNazivGrada;
        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.ComboBox comboDrzava;
        private System.Windows.Forms.Button btnSpremiDrzavu;
        private System.Windows.Forms.Button btnSpremiGrad;
        private System.Windows.Forms.PictureBox pbPomoc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}