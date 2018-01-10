namespace TBP
{
    partial class frmJedinicaMjere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJedinicaMjere));
            this.lblPopisJedinicaMjere = new System.Windows.Forms.Label();
            this.dgvPopisJedinicaMjere = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajMjeru = new System.Windows.Forms.Button();
            this.btnIzmijeniMjeru = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisJedinicaMjere)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPopisJedinicaMjere
            // 
            resources.ApplyResources(this.lblPopisJedinicaMjere, "lblPopisJedinicaMjere");
            this.lblPopisJedinicaMjere.ForeColor = System.Drawing.Color.Black;
            this.lblPopisJedinicaMjere.Name = "lblPopisJedinicaMjere";
            // 
            // dgvPopisJedinicaMjere
            // 
            this.dgvPopisJedinicaMjere.AllowUserToAddRows = false;
            this.dgvPopisJedinicaMjere.AllowUserToDeleteRows = false;
            this.dgvPopisJedinicaMjere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisJedinicaMjere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv});
            resources.ApplyResources(this.dgvPopisJedinicaMjere, "dgvPopisJedinicaMjere");
            this.dgvPopisJedinicaMjere.MultiSelect = false;
            this.dgvPopisJedinicaMjere.Name = "dgvPopisJedinicaMjere";
            this.dgvPopisJedinicaMjere.ReadOnly = true;
            this.dgvPopisJedinicaMjere.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisJedinicaMjere.SelectionChanged += new System.EventHandler(this.dgvPopisJedinicaMjere_SelectionChanged);
            // 
            // Id
            // 
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Naziv, "Naziv");
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // btnDodajMjeru
            // 
            this.btnDodajMjeru.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.btnDodajMjeru, "btnDodajMjeru");
            this.btnDodajMjeru.ForeColor = System.Drawing.Color.Black;
            this.btnDodajMjeru.Name = "btnDodajMjeru";
            this.btnDodajMjeru.UseVisualStyleBackColor = false;
            this.btnDodajMjeru.Click += new System.EventHandler(this.prikaz);
            this.btnDodajMjeru.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnDodajMjeru.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnIzmijeniMjeru
            // 
            this.btnIzmijeniMjeru.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.btnIzmijeniMjeru, "btnIzmijeniMjeru");
            this.btnIzmijeniMjeru.ForeColor = System.Drawing.Color.Black;
            this.btnIzmijeniMjeru.Name = "btnIzmijeniMjeru";
            this.btnIzmijeniMjeru.UseVisualStyleBackColor = false;
            this.btnIzmijeniMjeru.Click += new System.EventHandler(this.prikaz);
            this.btnIzmijeniMjeru.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnIzmijeniMjeru.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // txtNaziv
            // 
            this.txtNaziv.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.txtNaziv, "txtNaziv");
            this.txtNaziv.Name = "txtNaziv";
            // 
            // lblNaziv
            // 
            resources.ApplyResources(this.lblNaziv, "lblNaziv");
            this.lblNaziv.ForeColor = System.Drawing.Color.Black;
            this.lblNaziv.Name = "lblNaziv";
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.btnSpremi, "btnSpremi");
            this.btnSpremi.ForeColor = System.Drawing.Color.Black;
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            this.btnSpremi.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnSpremi.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.btnObrisi, "btnObrisi");
            this.btnObrisi.ForeColor = System.Drawing.Color.Black;
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            this.btnObrisi.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnObrisi.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // frmJedinicaMjere
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnDodajMjeru);
            this.Controls.Add(this.btnIzmijeniMjeru);
            this.Controls.Add(this.dgvPopisJedinicaMjere);
            this.Controls.Add(this.lblPopisJedinicaMjere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmJedinicaMjere";
            this.Load += new System.EventHandler(this.frmJedinicaMjere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisJedinicaMjere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPopisJedinicaMjere;
        private System.Windows.Forms.DataGridView dgvPopisJedinicaMjere;
        private System.Windows.Forms.Button btnDodajMjeru;
        private System.Windows.Forms.Button btnIzmijeniMjeru;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}